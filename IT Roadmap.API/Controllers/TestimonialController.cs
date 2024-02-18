using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Roadmap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        [Route("GetAllUsertestimonials")]
        public List<Testimonial> GetAllUsertestimonials()
        {
            return _testimonialService.GetAllUsertestimonials();
        }

        [HttpGet]
        [Route("GetUsertestimonialById/{id}")]
        public Testimonial GetUsertestimonialById(decimal id)
        {
            return _testimonialService.GetUsertestimonialById(id);
        }

        [HttpPost]
        [Route("CreateUsertestimonial")]
        public IActionResult CreateUsertestimonial(Testimonial testimonial)
        {
            _testimonialService.CreateUsertestimonial(testimonial);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("UpdateUsertestimonial")]
        public IActionResult UpdateUsertestimonial(Testimonial testimonial)
        {
            _testimonialService.UpdateUsertestimonial(testimonial);
            return Ok();
        }

        [HttpPut]
        [Route("AcceptOrRejectTestimonial")]
        public IActionResult AcceptOrRejectTestimonial(Testimonial testimonial)
        {
            _testimonialService.AcceptOrRejectTestimonial(testimonial);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteUsertestimonial/{id}")]
        public IActionResult DeleteUsertestimonial(decimal id)
        {
            _testimonialService.DeleteUsertestimonial(id);
            return Ok();
        }
    }
}
