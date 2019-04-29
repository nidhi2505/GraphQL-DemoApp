using GraphQl.DotNetCore.MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.DotNetCore.MyApp.Repository
{
    public interface IScoreCardRepository
    {
        List<Fields> GetFields();
    }
}
