namespace Inventory.Dao
{
    public interface StorageAreaDao
    {
        public string location { get; set; }
        public int noOfRooms { get; set; }
        public int warehouseId { get; set; }
    }
}
