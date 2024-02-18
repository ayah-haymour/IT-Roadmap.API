using System;
using System.Collections.Generic;

namespace IT_Roadmap.Core.Data
{
    public partial class User
    {
        public User()
        {
            Learningpaths = new HashSet<Learningpath>();
            Preferences = new HashSet<Preference>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Userid { get; set; }
        public decimal? Roleid { get; set; }
        public string? Profileimage { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime? Registrationdate { get; set; }
        public string? Gender { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string? Address { get; set; }
        public string? Phonenumber { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Learningpath> Learningpaths { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
