using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
      [Table("Order")]
    public class Order
    {
         [Key]
        public int Id { get; set; }

       
        public string  OrderNumber { get; set; } = string.Empty;

        public double  TotalPrice { get; set; }
        public double  PaidAmount { get; set; }
        public DateTime? Updated { get; set; } = DateTime.Now;
        public DateTime? Created { get; set; } = DateTime.Now;
        public User User {get; set;}

        public int UserId { get; set; }

        public List<Item> Items { get; set; }
        // public bool Delete { get; set; }
        // public bool Voided { get; set; }
        // public virtual IList<OrderItem> OrderItem {get; set;}
        
    }
}