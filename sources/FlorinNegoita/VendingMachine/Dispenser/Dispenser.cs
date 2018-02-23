using System;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection containableItemsCollection;

        public Dispenser (ContainableItemsCollection collection)
        {
            containableItemsCollection = collection;
        }
        public Product Dispense(int index)
        {
            ContainableItem containableItem = containableItemsCollection.GetItem(index);

            if (containableItem == null)
                throw new ArgumentNullException(nameof(containableItem));

            containableItem.Product.Quantity --;
            return containableItem.Product;
        }

        public void Update()
        {
            
        }
    }
}