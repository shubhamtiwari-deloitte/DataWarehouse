using Inventory.Dao;
using Inventory.Database;
using Inventory.Models;

namespace Inventory.Services
{
    public class PalletService
    {
        DatabaseContext db;

        public PalletService()
        {
            db = new DatabaseContext();
        }

        public IEnumerable<Pallet> getAllPallets()
        {
            return db.pallets.ToList();
        }

        public Pallet findPalletById(string id)
        {
            try
            {
                Pallet res = db.pallets.SingleOrDefault(p => p.palletId == id);
                return res;
            }
            catch
            {
                return null;
            }
        }


        public Pallet updatePalletInfo(string id)
        {
            try
            {
                Pallet res = db.pallets.SingleOrDefault(p => p.palletId == id);
                if (res == null)
                {
                    return null;
                }
                else
                {
                    res.isEmpty = false;
                    RoomsService roomService=new RoomsService();
                    roomService.updatePalletInfo(res.roomId, -1);
                    db.SaveChanges();
                    return res;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public bool addPallet(PalletDao palletDao)
        {
            try {
                Pallet pallet = new Pallet()
                {
                    palletId = Guid.NewGuid().ToString(),
                    palletNo=palletDao.palletNo,
                    isEmpty=true,
                    roomId=palletDao.roomId
                };
                db.pallets.Add(pallet);
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
