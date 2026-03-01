using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.Errors
{
    internal class CountryCodeMismatchError : DomainError
    {
        public CountryCodeMismatchError(string countryCode, string postalCode) : base($"The country code '{countryCode}' does not match the postal code '{postalCode}'.")
        {
        }
    }
}
