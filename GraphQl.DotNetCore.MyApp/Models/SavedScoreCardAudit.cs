using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class SavedScoreCardAudit
    {
        public int Id { get; set; }
        public int ScoreCardId { get; set; }
        public string TeamId { get; set; }
        public int? SprintId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string CustomerFeedback { get; set; }
        public string TeamRating { get; set; }
        public string ImpactScore { get; set; }
        public string ScrumMaster { get; set; }
        public string Auditor { get; set; }
        public string ProductOwner { get; set; }
        public int? CategoryId { get; set; }
        public string SprintName { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsPublished { get; set; }
        public string Action { get; set; }

        public SavedScoreCard ScoreCard { get; set; }
    }
}
