﻿using System.Runtime.Serialization;

namespace BookStore.Application.Errors;

[Serializable]
public class ResponseStreamNullException : BaseException
{
    public ResponseStreamNullException() { }
    public ResponseStreamNullException(String message) : base(message) { }
    public ResponseStreamNullException(String message, Exception inner) : base(message, inner) { }
    protected ResponseStreamNullException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}