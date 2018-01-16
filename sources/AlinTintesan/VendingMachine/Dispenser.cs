using System;

namespace VendingMachine
{
    public class Dispenser
    {
        public ContainableItemsCollection containableItemsCollection { get; }
        
        public Dispenser(ContainableItemsCollection containableItemsCollection)
        {
            this.containableItemsCollection=containableItemsCollection;
        }

        public Product Dispense(int productID)
        {
            Product productToDispense=new Product();
            productToDispense=this.containableItemsCollection.GetProductByID(productID);
            if(productToDispense==null)
            {
                Console.WriteLine("Product unavailable!");
                return null;
            }
            else
            {
                productToDispense.Quantity--;
                Console.WriteLine($"Dispensed: {productToDispense}");
                return productToDispense;
            }
        }

        public Product GetProductByID(int id)
        {
            return this.containableItemsCollection.GetProductByID(id);
        }
    }
}