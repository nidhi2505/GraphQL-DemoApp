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
        }
        [GraphQLMetadata("fieldById")]
        public Fields GetDroid(int id)
        {
            var repo = new ScoreCardRepository(new Models.AgilityInsightContext());
            return repo.GetFields().ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
