using Less16_Controllers.Models;
using Less16_Controllers.Models.Domain;

namespace Less16_Controllers.Services
{
    public class InventoryService
    {
        Inventory inventory;
        public InventoryService(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void AddProduct(Products prod)
        {
            inventory.prods.Add(prod);
        }


        public List<Products> GetAllProduct()
        {
            return inventory.prods;
        }

        public void UpdateProduct(int prodID, Products prod)
        {
            inventory.prods[prodID] = prod;
        }
        public decimal AllProductCost()
        {
            decimal result = 0;
            foreach (Products prod in inventory.prods)
            {
                result += prod.Price;
            }
            return result;
        }
    }
}
