using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.ValueObjects;

using Transport.Domain.Errors;
using Transport.Domain.Validators;

public record struct PostalCode
{
    public string Value { get; init; }
    public CountryCode CountryCode { get; init; }
    private PostalCode(string value, CountryCode code) {
    this.Value = value;
    this.CountryCode = code;

    }

    public static PostalCode Of(string value, CountryCode code) {

        if (string.IsNullOrWhiteSpace(value))
        {
        throw new PostalCodeNotGivenError();
        }

        PostalCodeValidator.Validate(value, code);

        return new PostalCode(value, code);
    }

}
