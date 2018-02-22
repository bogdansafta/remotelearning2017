using System;
namespace ProductImplementation
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection collection;
        public Dispenser(ContainableItemsCollection collection)
        {
            this.collection = collection;
        }
        private ContainableItem VerifyCollection(int id)
        {
            if (collection.Count < 1)
            {
                throw new Exception("Collection is empty!");
            }
            ContainableItem toDispense = collection.FindByID(id);
            if (toDispense == null)
            {
                throw new NullReferenceException();
            }
            return toDispense;
        }
        private void Dispense(int id)
        {
            ContainableItem toDispense = VerifyCollection(id);
            System.Console.WriteLine($"Dispensing:{toDispense.product.Name}");
            toDispense.product.Quantity--;
        }
        
        public void Notify(int id)
        {
            System.Console.WriteLine("Dispenser notified!");
            Dispense(id);
        }
        public Product GetProduct(int id)
        {
            ContainableItem toDispense = VerifyCollection(id);
            return toDispense.product;
        }
    }
}