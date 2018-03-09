using System;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection containableItemsCollection;
        private Singleton singleton = Singleton.Instance;

        public Dispenser(ContainableItemsCollection collection)
        {
            containableItemsCollection = collection;
        }
        public Product DispenseProduct(int productId)
        {
            ContainableItem containableItem = containableItemsCollection.GetItem(productId);

            if (containableItem == null)
                throw new ArgumentNullException(nameof(containableItem));
            
            return containableItem.Product;
        }

        public void Dispense(int productId)
        {
            ContainableItem containableItem = containableItemsCollection.GetItem(productId);
            singleton.CollectSalesData(containableItem.Product, DateTime.Now);
            singleton.CollectStocksData(containableItem.Product);
            singleton.CollectVolumesData(containableItem.Product);
        }

        public void Update(Product product)
        {
            int idProduct = containableItemsCollection.GetProductId(product);
            Dispense(idProduct);
        }
    }
}