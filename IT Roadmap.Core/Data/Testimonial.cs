using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public decimal? Userid { get; set; }
        public string? Testimonialtext { get; set; }
        public string? Status { get; set; }
        public DateTime? Testimonialdate { get; set; }

        public virtual User? User { get; set; }
    }
}
