using System;
using System.Text;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        public ContainableItemsCollection containableItemsCollection { get; }

        public Product dispensedProduct {get; private set; }
        public Repository repository;

        public Dispenser(ContainableItemsCollection containableItemsCollection)
        {
            this.containableItemsCollection = containableItemsCollection;
            this.repository = Repository.Instance;
            this.repository.UpdateStockAndVolume(this.containableItemsCollection);
        }

        private StringBuilder generateCurrentStock()
        {
            StringBuilder toReturn = new StringBuilder();
            for (int index = 0; index < this.containableItemsCollection.Count(); index++)
            {
                toReturn.Append(this.containableItemsCollection.Get(index).Product.ToString());
                toReturn.AppendLine();
            }
            return toReturn;
        }

        public Product Dispense(int productID)
        {
            Product productToDispense = new Product();
            productToDispense = this.containableItemsCollection.GetProductByID(productID);
            if (productToDispense == null)
            {
                throw new ProductUnavailableException();
            }
            else
            {
                productToDispense.Quantity--;
                this.dispensedProduct=productToDispense;
                return productToDispense;
            }
        }

        public void Update(Product product)
        {
            int ID = this.containableItemsCollection.GetProductID(product);
            this.Dispense(ID);
        }

        public Product GetProductByID(int id)
        {
            return this.containableItemsCollection.GetProductByID(id);
        }

        public void Report()
        {
            this.repository.writeReport();
        }
    }
}