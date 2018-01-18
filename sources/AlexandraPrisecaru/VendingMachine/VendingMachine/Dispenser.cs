using System.Linq;

namespace VendingMachine
{
    public class Dispenser
    {
        public Product Dispense(int id)
        {
            Product product = GetProduct(id);
            VendingMachine.Instance.Items.FirstOrDefault(item => item.Product.Equals(product))
                                   .Product.Quantity--;

            return product;
        }

        public Product GetProduct(int id)
        {
            return VendingMachine.Instance.Items.GetProductById(id);
        }
    }
}