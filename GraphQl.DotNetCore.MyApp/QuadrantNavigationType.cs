using GraphQl.DotNetCore.MyApp.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.DotNetCore.MyApp
{
    public class QuadrantNavigationType :ObjectGraphType<Quadrants>
    {
        public QuadrantNavigationType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.IsActive);
            Field(x => x.FieldType);
            Field(x => x.TeamType);
        }
    }
}
