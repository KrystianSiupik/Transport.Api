using System;
using System.Collections.Generic;
using System.Text;

using Transport.Domain.Errors;
namespace Transport.Domain.ValueObjects
{
    public sealed record Route
    {
        public PostalCode Origin { get; init; }
        public PostalCode Target { get; init; }
            

        private Route(PostalCode origin, PostalCode target)
        {
            this.Origin = origin;
            this.Target = target;
        }

        public static Route Of( PostalCode origin, PostalCode target)
        {
            if (origin == target)
            {
                throw new OriginAndTargetCannotBeEqualError();
            }

            return new Route(origin, target);
        }

    }
}
