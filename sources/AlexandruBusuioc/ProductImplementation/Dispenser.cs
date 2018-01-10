using System;
namespace ProductImplementation
{
    public class Dispenser
    {
        private ContainableItemsCollection collection;
        public Dispenser(ContainableItemsCollection collection)
        {
            this.collection = collection;
        }

        public Product Dispense(int id)
        {
            if(collection.Count<1)
            {
                System.Console.WriteLine("Collection is empty!");
                return null;
            }
            ContainableItem toDispense = collection.FindByID(id);
            if(toDispense==null)
            {
                return null;
            }
            System.Console.WriteLine($"Removing:{toDispense}");
            collection.Remove(toDispense);
            return toDispense.product;
        }
    }
}