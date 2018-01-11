using System;

namespace VendingMachine
{
    internal class Dispenser
    {
        private ContainableItemsCollection collection;

        public Dispenser(ContainableItemsCollection collection)
        {
            this.collection = collection;
        }
        public void Dispense(int ID)
        {
            if (!collection.DecrementQuantity(ID))
                throw new MyException("The ID is not recognized");
        }
        public Product GetProductViaID(int ID)
        {
            Product product = collection.GetProductViaID(ID);
            if (product != null)
                return product;
            else
                throw new MyException("No product on this ID");

        }
    }
}