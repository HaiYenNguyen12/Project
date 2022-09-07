
using ManageProject.API.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManageProject.API.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<Account>  Accounts { get; set; }
    }
}