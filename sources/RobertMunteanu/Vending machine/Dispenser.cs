using System;
namespace VendingMachine
{
    class Dispenser : IPaymentListener
    {
        private ContainableItemCollection collection = new ContainableItemCollection();

        public Product Dispense(Position position)
        {
            if (collection.Count > 0)
            {
                ContainableItem itemToDispense = new ContainableItem(position);
                Product productToDispense = itemToDispense.Product;
                collection.RemoveByPosition(position);
                return productToDispense;
            }
            else
            {
                return null;
            }
        }

        public void Update()
        {
        }
    }
}