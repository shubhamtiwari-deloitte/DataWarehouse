namespace Inventory.Models
{
    public class StorageArea
    {
        public string storageAreaID { get; set; }

        public string location { get; set; }
        public int noOfRooms { get; set; }
        public int warehouseId { get; set; }
    }
}
