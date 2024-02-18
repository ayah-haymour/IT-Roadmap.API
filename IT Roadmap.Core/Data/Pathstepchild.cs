using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Pathstepchild
    {
        public decimal Stepchildid { get; set; }
        public string? Stepname { get; set; }
        public decimal? Stepnumber { get; set; }
        public string? Completed { get; set; }
        public string? Image { get; set; }
        public decimal? Pathid { get; set; }
        public decimal? Resorceid { get; set; }
        public decimal? Stepid { get; set; }

        public virtual Learningpath? Path { get; set; }
        public virtual Learningresorce? Resorce { get; set; }
        public virtual Pathstep? Step { get; set; }
    }
}
