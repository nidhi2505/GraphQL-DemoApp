using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class RisksAndImpediments
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Ownership { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public int? CommentType { get; set; }
        public int? ScoreCardId { get; set; }
        public int? UpdatedForScoreCardId { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public SavedScoreCard ScoreCard { get; set; }
    }
}
