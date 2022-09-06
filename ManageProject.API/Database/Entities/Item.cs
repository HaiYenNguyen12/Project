using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
      [Table("Item")]
    public class Item
    {
         [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string  Name { get; set; }

        
    
        [StringLength(255)]
        public string  Description { get; set; }
        
    }
}