using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.Errors
{
    internal class DomainError : Exception
    {
        public DomainError(string message) : base(message)
        {
        }
    }
}
