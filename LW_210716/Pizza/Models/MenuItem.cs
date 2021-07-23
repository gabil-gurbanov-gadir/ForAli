using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(350)]
        public string Desc { get; set; }

        [Column(TypeName ="money")]
        public double Price { get; set; }

        public Category Category { get; set; }
    }
}
