using Inventory.Dao;
using Inventory.Database;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Services
{
    public class WarehouseService
    {
        DatabaseContext db;
       public WarehouseService()
       {
            db=new DatabaseContext();
       }

       public IEnumerable<Warehouse> getWarehouses()
        {
            return db.warehouses.ToList();
        }

        public Warehouse getWarehouseById(string name)
        {
            try
            {
                return db.warehouses.SingleOrDefault(w => w.warehouseName == name);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool addWarehouse(WarehouseDao warehouseDao)
        {
            try
            {
                string id = Guid.NewGuid().ToString();

                Warehouse warehouse = new Warehouse()
                {
                    warehouseId = id,
                    warehouseName = warehouseDao.warehouseName,
                    location = warehouseDao.location
                };

                db.warehouses.Add(warehouse);

                return true;
            }
            catch(Exception ex)
            {   
                Console.WriteLine(ex.Message);
                return false;
            }

        }


    }
}
