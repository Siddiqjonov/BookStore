using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Persistence.DataContext;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class EmailVarificationCodeRepository : IEmailVarificationCodeRepository
{
    private readonly AppDbContext _context;

    public EmailVarificationCodeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<EmailVerificationCode?> GetByIdAsync(long id)
    {
        return await _context.EmailVerificationCodes.FindAsync(id);
    }

    public async Task<EmailVerificationCode?> GetByEmailAsync(string email)
    {
        return await _context.EmailVerificationCodes
            .FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task SendVerificationCodeAsync(string email)
    {
        // 1. Generate code (4 letters + 4 digits)
        var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var digits = "0123456789";
        var random = new Random();

        var codeChars = new List<char>();
        codeChars.AddRange(Enumerable.Range(0, 4).Select(_ => letters[random.Next(letters.Length)]));
        codeChars.AddRange(Enumerable.Range(0, 4).Select(_ => digits[random.Next(digits.Length)]));
        codeChars = codeChars.OrderBy(_ => random.Next()).ToList();
        var code = new string(codeChars.ToArray());

        // 2. Send email
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("App", "no.reply.todolist.code@gmail.com"));
        message.To.Add(new MailboxAddress(string.Empty, email));
        message.Subject = "Your Verification Code";
        message.Body = new TextPart("plain") { Text = $"Your verification code is: {code}" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        await client.AuthenticateAsync("no.reply.todolist.code@gmail.com", "npsm qycf ozqa rmos");
        await client.SendAsync(message);
        await client.DisconnectAsync(true);

        // 3. Save to DB
        var entity = new EmailVerificationCode
        {
            Email = email,
            Code = code,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddHours(2),
            IsUsed = false
        };

        await _context.EmailVerificationCodes.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> VerifyCodeAsync(string email, string code)
    {
        var record = await _context.EmailVerificationCodes
            .FirstOrDefaultAsync(x => x.Email == email && x.Code == code && !x.IsUsed && x.ExpiresAt > DateTime.UtcNow);

        if (record is null)
            return false;

        record.IsUsed = true;
        await _context.SaveChangesAsync();
        return true;
    }
}
