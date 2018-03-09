using System;
using System.Linq;
namespace VendingMachine
{
    public class Dispenser:IPaymentNotifer
    {
          
        private static LinkedList<ContainableItem> listofProducts=ContainableItemsCollection.GetList();
        
        public static string Message="";
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

       
        private string Dispense(int id)
        {  
            
            ContainableItem item=listofProducts.FirstOrDefault(itemToDispense =>itemToDispense.Position.Id ==id);
            item.Product.Quantity--;
            DataAcquisition.GetInstance().LoadData(item.Product,DateTime.Now);
            return ($"Quantity left for {item.Product.Name} is {item.Product.Quantity}" );
            
            
        }

        public void update(int id)
        {
           
            Message = Dispense(id);
            //DataAcquizition.GetInstance().GenerateReports();
        }


    }
}