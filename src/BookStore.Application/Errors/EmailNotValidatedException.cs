﻿using System.Runtime.Serialization;

namespace BookStore.Application.Errors;

[Serializable]
public class EmailNotValidatedException : BaseException
{
    public EmailNotValidatedException() { }
    public EmailNotValidatedException(String message) : base(message) { }
    public EmailNotValidatedException(String message, Exception inner) : base(message, inner) { }
    protected EmailNotValidatedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}