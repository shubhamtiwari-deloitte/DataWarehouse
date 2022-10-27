using Microsoft.EntityFrameworkCore;
using Producer.Models;

namespace Producer.Database
{
    public class DatabaseContext:DbContext
    {

        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-4880I5O; initial catalog=tempdb; persist security info=True; user id=shubham; password=Password123");
        }
    }
}
