using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Text.RegularExpressions;
using Transport.Domain.Errors;
using Transport.Domain.ValueObjects;



namespace Transport.Domain.Validators
{
    public static class PostalCodeValidator
    {

        private static readonly Dictionary<CountryCode, Regex> Patterns = new()
    {
        { CountryCode.PL, new Regex(@"^\d{2}-\d{3}$", RegexOptions.Compiled) },
        { CountryCode.CZ, new Regex(@"^\d{3}\s?\d{2}$", RegexOptions.Compiled) }
    };
        public static void Validate(string postalCode, CountryCode code )
        {
            if (String.IsNullOrEmpty(postalCode)) { 
                throw new PostalCodeNotGivenError();
            }

            if(!Patterns.TryGetValue(code, out var pattern))
            {
                throw new UnsupportedCountryCodeError(code.ToString());
            }

            if (!pattern.IsMatch(postalCode))
            {
                throw new CountryCodeMismatchError(code.ToString(), postalCode);
            }
        }
    }
}
