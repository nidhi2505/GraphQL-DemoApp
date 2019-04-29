using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class Quadrants
    {
        public Quadrants()
        {
            Fields = new HashSet<Fields>();
            QuadrantFieldValues = new HashSet<QuadrantFieldValues>();
            QuadrantFieldValuesAudit = new HashSet<QuadrantFieldValuesAudit>();
            TeamScoreCardTemplate = new HashSet<TeamScoreCardTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldType { get; set; }
        public bool? IsActive { get; set; }
        public int TeamType { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ICollection<Fields> Fields { get; set; }
        public ICollection<QuadrantFieldValues> QuadrantFieldValues { get; set; }
        public ICollection<QuadrantFieldValuesAudit> QuadrantFieldValuesAudit { get; set; }
        public ICollection<TeamScoreCardTemplate> TeamScoreCardTemplate { get; set; }
    }
}
