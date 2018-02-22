using System;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
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

        public void Update() 
        {
            Console.WriteLine("Product dispensed!");
        }
        
        public Product GetProductByID(int id)
        {
            return this.containableItemsCollection.GetProductByID(id);
        }
    }
}