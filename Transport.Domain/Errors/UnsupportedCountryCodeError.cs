using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.Errors
{
    internal class UnsupportedCountryCodeError : DomainError
    {
        public UnsupportedCountryCodeError(string countryCode) : base($"The country code '{countryCode}' is not supported.")
        {
        }
    }
}
