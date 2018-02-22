using System;
using System.Linq;
namespace VendingMachine
{
    public class Dispenser:IPaymentNotifer
    {
          
        private static LinkedList<ContainableItem> listofProducts=ContainableItemsCollection.GetList();
        
        public static Product GetProduct(int id)
        {
             ContainableItem item=listofProducts.FirstOrDefault(itemToDispense =>itemToDispense.Position.Id ==id);
            if(item==null)
            {
             throw new System.Exception("The id dosen't exist");
            }
            if(item.Product.Quantity<=0)
            {
                throw new System.Exception("The product is not in the stock for the moment");
            }

             return item.Product;
        }
        private void Dispense(int id)
        {  
            
            ContainableItem item=listofProducts.FirstOrDefault(itemToDispense =>itemToDispense.Position.Id ==id);
            item.Product.Quantity--;
            Console.WriteLine($"Quantity left for {item.Product.Name} is {item.Product.Quantity}" );
            
        }

        public void update(int id)
        {
            Dispense(id);

        }
    }
}