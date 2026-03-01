using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.Errors
{
    internal class PostalCodeNotGivenError : DomainError
    {
        public PostalCodeNotGivenError() : base("Postal code was not given.")
        {
        }
    }
}
