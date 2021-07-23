using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public int ChefId { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Desc { get; set; }

        [MaxLength(4000)]
        public string Text { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime Date { get; set; }

        public Chef Chef { get; set; }

        public List<BlogTag> BlogTags { get; set; }
    }
}
