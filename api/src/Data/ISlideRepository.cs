using System.Collections.Generic;
using Schaudepots.Api.Models;

namespace Schaudepots.Api.Data
{
    public interface ISlideRepository
    {
        IList<SlideModel> Get();
    }
}
