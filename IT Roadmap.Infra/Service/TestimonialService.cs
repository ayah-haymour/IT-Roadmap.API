using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.Repository;
using IT_Roadmap.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestmonialRepository _testimonialRepository;

        public TestimonialService(ITestmonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public List<Testimonial> GetAllUsertestimonials()
        {
            return _testimonialRepository.GetAllUsertestimonials();
        }

        public Testimonial GetUsertestimonialById(decimal id)
        {
            return _testimonialRepository.GetUsertestimonialById(id);
        }

        public void CreateUsertestimonial(Testimonial testimonialData)
        {
            _testimonialRepository.CreateUsertestimonial(testimonialData);
        }

        public void UpdateUsertestimonial(Testimonial testimonialData)
        {
            _testimonialRepository.UpdateUsertestimonial(testimonialData);
        }

        public void DeleteUsertestimonial(decimal id)
        {
            _testimonialRepository.DeleteUsertestimonial(id);
        }
        public void AcceptOrRejectTestimonial(Testimonial testimonialData)
        {
            _testimonialRepository.AcceptOrRejectTestimonial(testimonialData);
        }

    }
}
