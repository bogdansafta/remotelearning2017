using System;
namespace VendingMachine
{
    class Dispenser
    {
        private ContainableItemCollection collection;

        public Product Dispense(int Id)
        {
            Product productToReturn = collection.ItemById(Id).Product;
            collection.RemoveById(Id);
            return productToReturn;
        }
    }
}