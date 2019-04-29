using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.DotNetCore.MyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.DotNetCore.MyApp.Repository
{
    public class ScoreCardRepository : IScoreCardRepository
    {
        private readonly AgilityInsightContext _context;
        public ScoreCardRepository(AgilityInsightContext context)
        {
            _context = context;
        }
        public List<Fields> GetFields()
        {

            return _context.Fields.ToList();
        }
    }
}
