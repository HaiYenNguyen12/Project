using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
      [Table("GuestTable")]
    public class GuestTable
    {
         [Key]
        public int Id { get; set; }

        public string  Name { get; set; } 
        public string  Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool  Delete { get; set; }

        public virtual Status Status {get; set;}
        public virtual Guest  Guest{get; set;}
        
    }
}