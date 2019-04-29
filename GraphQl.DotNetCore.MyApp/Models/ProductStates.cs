using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class ProductStates
    {
        public ProductStates()
        {
            FieldProductMapping = new HashSet<FieldProductMapping>();
            TeamCategory = new HashSet<TeamCategory>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public ICollection<FieldProductMapping> FieldProductMapping { get; set; }
        public ICollection<TeamCategory> TeamCategory { get; set; }
    }
}
