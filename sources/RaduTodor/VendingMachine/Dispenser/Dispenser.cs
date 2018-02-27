using System;
using System.Collections.Generic;

namespace VendingMachine
{
    internal class Dispenser : IPaymentListener
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
            adaugareData(ID);
        }
        public Product GetProductViaID(int ID)
        {
            Product product = collection.GetProductViaID(ID);
            if (product != null)
                return product;
            else
                throw new MyException("No product on this ID");

        }

        public void Update()
        {
            Console.WriteLine("A product has been disposed");
        }

        public void adaugareData(int ID)
        {
            Data singleton=Data.Instance;
            singleton.SetData(GetProductViaID(ID),DateTime.Now);
        }
    }
}