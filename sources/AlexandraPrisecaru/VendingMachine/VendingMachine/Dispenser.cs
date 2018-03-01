using System.Linq;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        public Product Dispense(int id)
        {
            Product product = GetProduct(id);
            if (product == null || product.Quantity == 0)
            {
                throw new ProductNotFoundException();
            }

            VendingMachine.Instance.Items.Select(item => item.Product).FirstOrDefault(prod => prod.Equals(product)).Quantity--;
            DataAcquisition.Instance.AddToSales(product);
            
            return product;
        }

        public Product GetProduct(int id)
        {
            return VendingMachine.Instance.Items.GetProductById(id);
        }

        public void Update(int idProduct)
        {
            Dispense(idProduct);
        }
    }
}