using System;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection containableItemsCollection;

        public Dispenser(ContainableItemsCollection collection)
        {
            containableItemsCollection = collection;
        }
        public Product DispenseProduct(int productId)
        {
            ContainableItem containableItem = containableItemsCollection.GetItem(productId);

            if (containableItem == null)
                throw new ArgumentNullException(nameof(containableItem));

            containableItem.Product.Quantity--;
            
            return containableItem.Product;
        }

        public void Dispense(int productId)
        {
            CollectProductData(productId);
        }

        public void CollectProductData(int productId)
        {
            Singleton singleton = Singleton.Instance;
            singleton.CollectData(DispenseProduct(productId), DateTime.Now);
        }

        public void Update()
        {
            Console.WriteLine("Product dispense.");
        }
    }
}