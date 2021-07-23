using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Chef
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string About { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
