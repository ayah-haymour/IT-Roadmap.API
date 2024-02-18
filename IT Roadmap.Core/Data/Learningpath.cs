using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Learningpath
    {
        public Learningpath()
        {
            Pathstepchildren = new HashSet<Pathstepchild>();
            Pathsteps = new HashSet<Pathstep>();
        }

        public decimal Pathid { get; set; }
        public string? Compleationstatus { get; set; }
        public decimal? Skillid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Skill? Skill { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Pathstepchild> Pathstepchildren { get; set; }
        public virtual ICollection<Pathstep> Pathsteps { get; set; }
    }
}
