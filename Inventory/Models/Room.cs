namespace Inventory.Models
{
    public class Room
    {
        public string roomId { get; set; }
        public int noOfPallets { get; set; }
        public int noOfEmptyPallets { get; set; }
        public int storageAreaId { get; set;  }
    }
}
