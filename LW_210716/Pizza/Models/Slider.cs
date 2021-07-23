using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Slider
    {
        public int Id { get; set; }

        
        [MaxLength(25)]
        public string Subheading { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(225)]
        public string Desc { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string RedirectUrlOrder { get; set; }

        [MaxLength(250)]
        public string RedirectUrlMenu { get; set; }
    }
}
