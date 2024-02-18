using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Pathstep
    {
        public Pathstep()
        {
            Pathstepchildren = new HashSet<Pathstepchild>();
        }

        public decimal Stepid { get; set; }
        public string? Stepname { get; set; }
        public decimal? Stepnumber { get; set; }
        public string? Completed { get; set; }
        public string? Image { get; set; }
        public decimal? Pathid { get; set; }
        public decimal? Resorceid { get; set; }

        public virtual Learningpath? Path { get; set; }
        public virtual Learningresorce? Resorce { get; set; }
        public virtual ICollection<Pathstepchild> Pathstepchildren { get; set; }
    }
}
