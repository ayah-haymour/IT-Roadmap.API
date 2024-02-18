using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Preference
    {
        public decimal Preferencesid { get; set; }
        public string? Experiencelevel { get; set; }
        public string? Goals { get; set; }
        public decimal? Commitmenttime { get; set; }
        public decimal? Skillid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Skill? Skill { get; set; }
        public virtual User? User { get; set; }
    }
}
