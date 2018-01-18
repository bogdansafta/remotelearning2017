using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VendingMachine
{
    public class ContainableItemCollection 
    {
       List<ContainableItem> productList = new List<ContainableItem>();

        public void Add(ContainableItem newProduct)
        {
            productList.Add(newProduct);
        }

        public void Remove(ContainableItem product)
        {
            productList.Remove(product);
        }

        public int Count() => productList.Count();

        public ContainableItem GetItem(int index) => productList.GetItem(index) as ContainableItem;

        public ContainableItem GetByPosition(int idProduct) 
        {
            for (int index = 0; index < productList.Count(); index++)
            {
                ContainableItem item = productList.GetItem(index);
                if (item.Position.ID.Equals(idProduct) && item.Product.QuantityProduct >= 1)
                    return item.Product;
            }
            return null;

           /* for (int i = 0; i < productList.Count(); i++)
                if (productList.GetItem(i).Equals(position))
                    return productList.GetItem(i) as ContainableItem;
            return null;*/
        }

        public Product GetProductByID(int ID)
        {
            for (int index = 0; index < productList.Count(); index++)
            {
                ContainableItem item = productList.GetItem(index);
                if (item.Position.ID.Equals(ID) && item.Product.QuantityProduct >= 1)
                    return item.Product;
            }
            return null;
        }
    }
}
