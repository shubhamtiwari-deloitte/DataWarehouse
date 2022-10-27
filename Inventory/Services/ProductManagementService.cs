using Inventory.Dao;
using Inventory.Models;

namespace Inventory.Services
{
    public class ProductManagementService
    {
        PalletService palletService=new PalletService();
        public Product addProductToInventory(ProductDao productDao, string palletId)
        {
            Product product = new Product()
            {
                productId=productDao.productId,
                productName=productDao.productName,
                quantity=productDao.quantity,
                palletId=palletId
            };

            // Code to save the product to database

            palletService.updatePalletInfo(palletId); // to update the pallet info in which the product is placed

            return product;
        }
    }
}
