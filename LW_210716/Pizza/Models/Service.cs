using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Service
    {
        public int Id { get; set; }
        
        [MaxLength(150)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Subtitle { get; set; }
    }
}
