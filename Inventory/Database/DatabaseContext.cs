using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<StorageArea> storageAreas { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Pallet> pallets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-4880I5O; initial catalog=tempdb; persist security info=True; user id=shubham; password=Password123");
        }
    }

}
