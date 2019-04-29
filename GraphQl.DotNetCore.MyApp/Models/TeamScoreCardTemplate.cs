using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class TeamScoreCardTemplate
    {
        public int Id { get; set; }
        public string TeamId { get; set; }
        public int? FieldId { get; set; }
        public int QuadrantId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Fields Field { get; set; }
        public Quadrants Quadrant { get; set; }
    }
}
