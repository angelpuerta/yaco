using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using places.Models;
using places.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Services.Query
{
    public class PubSchema: Schema
    {
        public PubSchema(IServiceProvider provider, IPubService pubService)
        {
            {
                Query = provider.GetRequiredService<PubQuery>();
            }
        }
    }
}
