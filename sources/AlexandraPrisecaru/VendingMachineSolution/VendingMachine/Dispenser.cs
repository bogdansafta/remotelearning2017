using System.Linq;

namespace VendingMachine
{
    public class Dispenser
    {
        public Product Dispense(int id)
        {
            ContainableItem item = VendingMachine.Instance.Items.FirstOrDefault(containableItem => containableItem.Position.Id == id);

            if (item == null)
            {
                throw new System.Exception("Invalid id.");
            }

            if (item.Product == null || item.Product.Quantity < 1)
            {
                throw new System.Exception("No product found at this id.");
            }

            item.Product.Quantity--;

            return item.Product;
        }
    }
}