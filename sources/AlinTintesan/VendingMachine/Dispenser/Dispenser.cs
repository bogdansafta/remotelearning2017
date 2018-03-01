using System;
using System.Text;

namespace VendingMachine
{
    public class Dispenser : IPaymentListener
    {
        public ContainableItemsCollection containableItemsCollection { get; }

        private Repository repository;
        
        public Dispenser(ContainableItemsCollection containableItemsCollection)
        {
            this.containableItemsCollection=containableItemsCollection;
            this.repository=Repository.Instance;
        }

        private StringBuilder generateCurrentStock()
        {
            StringBuilder toReturn=new StringBuilder();
            for(int index=0; index<this.containableItemsCollection.Count(); index++)
            {
                toReturn.Append(this.containableItemsCollection.Get(index).Product.ToString());
                toReturn.AppendLine();
            }
            return toReturn;
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
                this.repository.writeReport(productToDispense.ToString(),this.generateCurrentStock());
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

        public void PrintReport()
        {
            this.repository.printReport();
        }
    }
}