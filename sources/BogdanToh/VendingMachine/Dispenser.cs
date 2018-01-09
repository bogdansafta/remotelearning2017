using System;
using System.Linq;
namespace VendingMachine
{
    public class Dispenser
    {
          
        private static LinkedList<ContainableItem> listofProducts=ContainableItemsCollection.GetList();
               
        public static Product Dispense(int id)
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
            item.Product.Quantity--;
            return item.Product;
        }
    }
}