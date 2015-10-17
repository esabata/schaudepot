using System.Collections.Generic;
using System.Web.Http;
using Schaudepots.Api.Data;
using Schaudepots.Api.Models;

namespace Schaudepots.Api.Controllers
{
    public class SlidesController : ApiController
    {
        private readonly ISlideRepository slideRepository;

        public SlidesController(ISlideRepository slideRepository)
        {
            this.slideRepository = slideRepository;
        }

        // GET api/slides
        public IList<SlideModel> Get()
        {
            return slideRepository.Get();
        }
    }
}
