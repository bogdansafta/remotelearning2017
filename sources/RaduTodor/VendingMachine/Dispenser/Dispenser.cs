using System;
using System.Collections.Generic;

namespace VendingMachine
{
    internal class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection collection;

        internal ContainableItemsCollection Collection { get => collection; set => collection = value; }

        public Dispenser(ContainableItemsCollection collection)
        {
            this.collection = collection;
        }

        public void Dispense(int iD)
        {
            if (!collection.DecrementQuantity(iD))
            {
                throw new MyException("The ID is not recognized");
            }
        }

        public Product GetProductViaID(int iD)
        {
            Product product = collection.GetProductViaID(iD);
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new MyException("No product on this ID");
            }

        }

        public void Update(int iD)
        {
            Dispense(iD);
            Console.WriteLine($"The product with the ID={iD} has been disposed");
        }
    }
}