using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Domain.Errors
{
    internal class OriginAndTargetCannotBeEqualError : DomainError
    {
        public OriginAndTargetCannotBeEqualError() : base("The origin and target locations cannot be the same.")
        {
        }
    }
}
