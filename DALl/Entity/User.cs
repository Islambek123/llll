using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALl.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 200)]
        public string NickName { get; set; }
        [Required, StringLength(maximumLength: 200)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 200)]
        public string Password { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public float Mony { get; set; }
    }
}
