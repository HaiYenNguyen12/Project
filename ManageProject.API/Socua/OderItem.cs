using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
      [Table("OrderItem")]
    public class OrderItem
    {
         [Key]
        public int Id { get; set; }
        public string  Name { get; set; }


        public double  SalePrice { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        public bool Delete { get; set; }
         public bool Voiced { get; set; }
         public virtual Item item {get; set;}
    }
}