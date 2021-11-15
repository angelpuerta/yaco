using GraphQL.Types;
using places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Types
{
    public class PubType: ObjectGraphType<Place>
    {
        public PubType()
        {
            Name = "Pub";
            Description = "";
            Field(d => d.Id, nullable: false).Description("The identificator of the pub");
            Field(d => d.Name, nullable: false).Description("The name of the bar");
        }
    }
}
