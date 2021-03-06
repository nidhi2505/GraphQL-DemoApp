﻿using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class QuadrantFieldValues
    {
        public int Id { get; set; }
        public int QuadrantId { get; set; }
        public int FieldId { get; set; }
        public int SavedScoreId { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public string CoachRecommendation { get; set; }
        public string QuadrantName { get; set; }
        public bool PrioritySet { get; set; }
        public int? ImpactValue { get; set; }
        public string ImpactDescription { get; set; }

        public Fields Field { get; set; }
        public Quadrants Quadrant { get; set; }
        public SavedScoreCard SavedScore { get; set; }
    }
}
