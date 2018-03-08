using System;
using System.Linq;
namespace Vending_machine_V2
{
    public class Dispenser : IPaymentListener
    {
        private static List<ContainableItem> productList = ContainableItemCollection.GetList();
        public void adaugareData(int identify)
        {
            Data singleton = Data.Instance;
            //singleton.SetData(DispenseProduct(identify), DateTime.Now);
        }
        public Product DispenseProduct(int identify)
        {
            ContainableItem item = productList.FirstOrDefault(itemToDispense => itemToDispense.position.id == identify);
            if (item == null)
            {
                throw new System.Exception("Id not available");
            }
            if (item.product.quantity <= 0)
            {
                throw new System.Exception("That item is no longer in vending machine");
            }
            item.product.quantity--;
            return item.product;
            adaugareData(identify);
        }
        public void Update()
        {

        }
    }
}