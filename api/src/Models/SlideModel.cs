using System.Collections.Generic;
using Newtonsoft.Json;

namespace Schaudepots.Api.Models
{
    public class SlideModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ValueModel> Slides { get; set; } 
    }
}