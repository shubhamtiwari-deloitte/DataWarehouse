using Producer.Database;
using Producer.Models;

namespace Producer.Services
{
    public class ProductService
    {
        DatabaseContext db;

        public ProductService()
        {
            db = new DatabaseContext();
        }

        public IEnumerable<Product> getAllProducts()
        {
            return db.products.ToList();
        }

        public Product getProductById(string id)
        {
            try
            {
                return db.products.SingleOrDefault(p => p.productId == id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Product saveProduct(string productName, int quantity)
        {
            try
            {
                Product product = new Product()
                {
                    productId = Guid.NewGuid().ToString(),
                    productName = productName,
                    quantity = quantity
                };

                db.products.Add(product);
                return product;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }


        public Product saveProductToInventory(string id)
        {
            Product product=this.getProductById(id);
            if (product!=null)
            {
                /*
                 * Code for saving product to inventory
                 */
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}