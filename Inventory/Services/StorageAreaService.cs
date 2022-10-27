using Inventory.Dao;
using Inventory.Database;
using Inventory.Models;

namespace Inventory.Services
{
    public class StorageAreaService
    {
        DatabaseContext db;
        public StorageAreaService()
        {
            db=new DatabaseContext();
        }


        public IEnumerable<StorageArea> getAllStorageArea()
        {
            return db.storageAreas.ToList();
        }


        public bool addStorageArea(StorageAreaDao storageAreaDao)
        {
            try
            {
                string id = Guid.NewGuid().ToString();

                StorageArea storageArea = new StorageArea()
                {
                    storageAreaID = id,
                    location = storageAreaDao.location,
                    noOfRooms = storageAreaDao.noOfRooms,
                    warehouseId = storageAreaDao.warehouseId
                };

                db.storageAreas.Add(storageArea);
                return true;
            }

            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
        }
    }
}
