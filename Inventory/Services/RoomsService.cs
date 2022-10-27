using Inventory.Dao;
using Inventory.Database;
using Inventory.Models;

namespace Inventory.Services
{
    public class RoomsService
    {
        DatabaseContext db;

        public RoomsService()
        {
            db = new DatabaseContext();
        }

        public IEnumerable<Room> getAllRooms()
        {
            return db.rooms.ToList();
        }

        public bool addRoom(RoomDao roomDao)
        {
            try
            {
                Room room = new Room()
                {
                    roomId = Guid.NewGuid().ToString(),
                    noOfPallets = roomDao.noOfPallets,
                    noOfEmptyPallets = roomDao.noOfPallets,
                    storageAreaId = roomDao.storageAreaId
                };
                db.rooms.Add(room);
                return true;
            }

            catch(Exception exc)
            {
                Console.WriteLine(exc.ToString());
                return false;
            }
        }

        public Room updatePalletInfo(string roomId, int palletsToBeUpdated)
        {
            try
            {
                Room room = db.rooms.SingleOrDefault(r => r.roomId == roomId);
                if(room != null)
                {
                    room.noOfPallets = room.noOfPallets+palletsToBeUpdated;
                    db.SaveChanges();
                    return room;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
