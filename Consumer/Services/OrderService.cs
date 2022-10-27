using Consumer.Database;
using Consumer.Models;

namespace Consumer.Services
{
    public class OrderService
    {
        DatabaseContext db;

        public OrderService()
        {
            db = new DatabaseContext();
        }

        public IEnumerable<Order> getAllOrders()
        {
            return db.orders.ToList();
        }

        public Order generateOrder(string productId, int qty)
        {
            try
            {
                Order order = new Order()
                {
                    orderId = Guid.NewGuid().ToString(),
                    productId = productId,
                    quantity = qty
                };
                db.orders.Add(order);
                return order;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Order orderFromInventory(Order order)
        {
            /*
             * Code for getting the order from inventory
             */
            return order;
        }
    }
}
