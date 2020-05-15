using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.ApplicationServices.Interfaces
{
    public abstract class UseCaseResponse
    {
        public bool Success { get; }

        public string Message { get; }

        protected UseCaseResponse(bool success = true, string message = null)
        {
            Success = success;
            Message = message;
        }
    }
}
