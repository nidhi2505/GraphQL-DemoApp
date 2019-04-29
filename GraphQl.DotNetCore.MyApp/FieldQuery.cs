using GraphQl.DotNetCore.MyApp.Models;
using GraphQl.DotNetCore.MyApp.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.DotNetCore.MyApp
{
    public class FieldQuery : ObjectGraphType
    {
        public FieldQuery(IScoreCardRepository scoreCardRepository)
        {
            Field<ListGraphType<FieldType>>("fields",
                resolve : context=> scoreCardRepository.GetFields());

            Field<FieldType>(
       "fieldById",
       arguments: new QueryArguments(
         new QueryArgument<IdGraphType> { Name = "id" }
       ),
       resolve: context =>
       {
           var id = context.GetArgument<int>("id");
           return scoreCardRepository.GetFields().FirstOrDefault(x => x.Id == id);
       });

        }
        [GraphQLMetadata("fieldById")]
        public Fields GetDroid(int id)
        {
            var repo = new ScoreCardRepository(new Models.AgilityInsightContext());
            return repo.GetFields().ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
