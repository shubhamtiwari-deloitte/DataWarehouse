using Consumer.Models;
using Microsoft.EntityFrameworkCore;

namespace Consumer.Database
{
    public class DatabaseContext: DbContext
    {

        public DbSet<Order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-4880I5O; initial catalog=tempdb; persist security info=True; user id=shubham; password=Password123");
        }
    }
}
