using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryillium.Models
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public Section Section { get; set; }
        public List<Work> Works { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<News> News { get; set; }
        public List<Feature>Features { get; set; }
    }
}
