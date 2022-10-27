namespace Inventory.Dao
{
    public interface ProductDao
    {
        public string productId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
    }
}
