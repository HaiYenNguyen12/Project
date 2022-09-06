using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string  Username { get; set; }

        
        [Required]
        [StringLength(255)]
        public string  Email { get; set; }


        [Required]
        [StringLength(10)]
        public string Password { get; set; }
   
        // public byte[] passwordHash { get; set; }
    }
}