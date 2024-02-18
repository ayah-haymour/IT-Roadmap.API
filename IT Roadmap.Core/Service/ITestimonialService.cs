using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Service
{
    public interface ITestimonialService
    {
        List<Testimonial> GetAllUsertestimonials();
        Testimonial GetUsertestimonialById(decimal id);
        void CreateUsertestimonial(Testimonial usertestimonialData);
        void UpdateUsertestimonial(Testimonial usertestimonialData);
        public void AcceptOrRejectTestimonial(Testimonial usertestimonialData);

        void DeleteUsertestimonial(decimal id);
    }
}
