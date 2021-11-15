using GraphQL.Instrumentation;
using GraphQL.Types;
using places.Models;
using places.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Services.Query
{
    public class PubQuery : ObjectGraphType
    {
        public PubQuery(IPubService pubService)
        {
            _ = Field<ListGraphType<PubType>>(
                "pub",
                resolve: context =>
                {
                    return pubService.Get();

                }
                );
        }
    }
}
