using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
      [Table("Unit")]
    public class Unit
    {
         [Key]
        public int Id { get; set; }

       
        public string  Name { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        public bool Delete { get; set; }
        public UnitType UnitType {get; set;}
       
    }
}