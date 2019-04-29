using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class SavedScoreCard
    {
        public SavedScoreCard()
        {
            QuadrantFieldValues = new HashSet<QuadrantFieldValues>();
            QuadrantFieldValuesAudit = new HashSet<QuadrantFieldValuesAudit>();
            RisksAndImpediments = new HashSet<RisksAndImpediments>();
            RisksAndImpedimentsAudit = new HashSet<RisksAndImpedimentsAudit>();
            SavedScoreCardAudit = new HashSet<SavedScoreCardAudit>();
        }

        public int Id { get; set; }
        public string TeamId { get; set; }
        public int SprintId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string ImpactScore { get; set; }
        public string TeamRating { get; set; }
        public string CustomerFeedback { get; set; }
        public string ScrumMaster { get; set; }
        public string Auditor { get; set; }
        public string ProductOwner { get; set; }
        public int? CategoryId { get; set; }
        public string SprintName { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }

        public ICollection<QuadrantFieldValues> QuadrantFieldValues { get; set; }
        public ICollection<QuadrantFieldValuesAudit> QuadrantFieldValuesAudit { get; set; }
        public ICollection<RisksAndImpediments> RisksAndImpediments { get; set; }
        public ICollection<RisksAndImpedimentsAudit> RisksAndImpedimentsAudit { get; set; }
        public ICollection<SavedScoreCardAudit> SavedScoreCardAudit { get; set; }
    }
}
