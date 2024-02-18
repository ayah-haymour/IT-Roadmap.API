using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Learningresorce
    {
        public Learningresorce()
        {
            Pathstepchildren = new HashSet<Pathstepchild>();
            Pathsteps = new HashSet<Pathstep>();
        }

        public decimal Resorceid { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Provider { get; set; }
        public string? Link { get; set; }

        public virtual ICollection<Pathstepchild> Pathstepchildren { get; set; }
        public virtual ICollection<Pathstep> Pathsteps { get; set; }
    }
}
