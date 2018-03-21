using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALl.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:200)]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required,StringLength(maximumLength:500)]
        public string Description { get; set; }
        [Required]
        public int Category { get; set; }
    }
}
