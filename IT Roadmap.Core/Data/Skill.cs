using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Skill
    {
        public Skill()
        {
            Learningpaths = new HashSet<Learningpath>();
            Preferences = new HashSet<Preference>();
        }

        public decimal Skillid { get; set; }
        public string? Skillname { get; set; }

        public virtual ICollection<Learningpath> Learningpaths { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
    }
}
