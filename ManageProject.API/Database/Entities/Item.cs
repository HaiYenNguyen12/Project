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

       
        public string  Name { get; set; }

        public string  Description { get; set; }

        public double  Price { get; set; }
        public double Discount { get; set; }
        public int  Quantity { get; set; }
        public DateTime? Updated { get; set; } = DateTime.Now;
        public DateTime? Created { get; set; } = DateTime.Now;
        public List<Order> Orders { get; set; }


        // public Category Category { get; set; }
        // public int CategoryId { get; set; }
        // public bool Delete { get; set; }
        // public virtual uint unit {get; set;}
        // public virtual IList<ItemImage> ItemImage {get; set;}
        
    }
}