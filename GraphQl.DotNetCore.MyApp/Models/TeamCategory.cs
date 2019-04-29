using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class TeamCategory
    {
        public int Id { get; set; }
        public string TeamId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ProductStates Category { get; set; }
    }
}
