using System;
namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemCollection collection;

        public Dispenser(ContainableItemCollection collection)
        {
            this.collection = collection;
        }

        private Product Dispense(int Id)
        {
            if (collection.Count > 0)
            {
                ContainableItem itemToDispense = collection.ItemById(Id);
                collection.RemoveById(Id);
                return itemToDispense.Product;
            }
            else
            {
                return null;
            }
        }

        public void Update(int Id)
        {
            Dispense(Id);
        }
    }
}