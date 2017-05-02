﻿using System;
using System.Net;

namespace RealWorld.Infrastructure
{
    public class RestException : Exception
    {
        public RestException(HttpStatusCode code, string message = null)
            : base(message)
        {
            Code = code;
        }

        public HttpStatusCode Code { get; }
    }
}