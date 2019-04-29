using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class Fields
    {
        public Fields()
        {
            FieldProductMapping = new HashSet<FieldProductMapping>();
            QuadrantFieldValues = new HashSet<QuadrantFieldValues>();
            QuadrantFieldValuesAudit = new HashSet<QuadrantFieldValuesAudit>();
            TeamScoreCardTemplate = new HashSet<TeamScoreCardTemplate>();
        }

        public int Id { get; set; }
        public int Quadrant { get; set; }
        public string FieldName { get; set; }
        public string FieldInfo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Quadrants QuadrantNavigation { get; set; }
        public ICollection<FieldProductMapping> FieldProductMapping { get; set; }
        public ICollection<QuadrantFieldValues> QuadrantFieldValues { get; set; }
        public ICollection<QuadrantFieldValuesAudit> QuadrantFieldValuesAudit { get; set; }
        public ICollection<TeamScoreCardTemplate> TeamScoreCardTemplate { get; set; }
    }
}
