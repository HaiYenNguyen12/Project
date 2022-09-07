using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ManageProject.API.Database.Entities
{
    [Table("Restaurant")]
    public class Restaurant{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string  Description { get; set; }
    public string Phone { get; set; }
    public string  Address { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public bool Deleted {get; set;}
    }
}