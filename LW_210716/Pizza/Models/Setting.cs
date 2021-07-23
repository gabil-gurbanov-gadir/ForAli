using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Street { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(150)]
        public string Schedule { get; set; }

        [MaxLength(500)]
        public string About { get; set; }

        [MaxLength(200)]
        public string Twitter { get; set; }

        [MaxLength(200)]
        public string Facebook { get; set; }

        [MaxLength(200)]
        public string Instagram { get; set; }


    }
}
