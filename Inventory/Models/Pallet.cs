namespace Inventory.Models
{
    public class Pallet
    {
        public string palletId { get; set; }
        public int palletNo { get; set; }
        public bool isEmpty { get; set; }
        public string roomId { get; set; }
    }
}
