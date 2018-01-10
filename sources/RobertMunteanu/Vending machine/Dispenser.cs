using System;
namespace VendingMachine
{
    class Dispenser
    {
        private ContainableItemCollection collection;


        //Start the collection with a given product list
        public void StartCollection(ContainableItem[] products)
        {
            this.collection = new ContainableItemCollection(products);
        }

        //Start the collection with a single known item
        public void StartCollection(ContainableItem product)
        {
            this.collection = new ContainableItemCollection(product);
        }


        //Reminder: a trebuit sa schimb argumentul din "int" in "position"
        public Product Dispense(Position position)
        {
            Product productToReturn = collection.ItemByPosition(position).Product;
            collection.RemoveByPosition(position);
            return productToReturn;
        }


        static void Main(string[] args)
        {
            
        }
    } 
}