using GraphQl.DotNetCore.MyApp.Models;
using GraphQL.Types;
using System;

namespace GraphQl.DotNetCore.MyApp
{
    public class FieldType : ObjectGraphType<Fields>
    {
        public FieldType()
        {
            Field(f => f.Id);
            Field(f => f.FieldName);
            Field(f => f.FieldInfo);
            Field(f => f.Quadrant);
            Field(f => f.IsActive);
            Field(f => f.LastModifiedDate, nullable: true);
            Field(f => f.CreatedBy);
            Field(name: "QuadrantNavigation",
            type: typeof(QuadrantNavigationType),
            resolve: context => context.Source.QuadrantNavigation);
            //Field(f => f.CreatedDate, nullable: true, type: typeof(DateTimeGraphType));
            Field(f => f.LastModifiedBy);
        }

     
    }
}
