using GraphQL;
using GraphQL.Types;

namespace GraphQl.DotNetCore.MyApp
{
    public class FieldSchema :Schema
    {
        public FieldSchema(IDependencyResolver resolver) :base(resolver)
        {
            Query = resolver.Resolve<FieldQuery>();
        }
    }
}
