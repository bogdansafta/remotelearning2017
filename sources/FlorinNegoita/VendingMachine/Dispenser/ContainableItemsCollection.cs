using System;

namespace VendingMachine
{
    public class  ContainableItemsCollection
    {
        private int size;

        private ContainableItem[] productList;

        public  ContainableItemsCollection()
        {
            size = 0;
            productList = new ContainableItem[size + 1];
        }

        public void AddProduct(ContainableItem product)
        {
            ContainableItem[] auxiliaryList = productList;
            productList = new ContainableItem[size + 1];

            for (int i = 0; i < auxiliaryList.Length; i++)
            {
                productList[i] = auxiliaryList[i];
            }

            productList[size] = product;
            size++;
        }

        public ContainableItem GetItem(int index)
        {
            if (index >= 0 && index < productList.Length)
                return productList[index];
            else
                return null;
        }

        public int Count()
        {
            return size;
        }

        public void Remove(ContainableItem product)
        {
            for (int i = 0; i < productList.Length; i++)
            {
                if (productList[i] == product)
                {
                    for (int j = i; j < productList.Length - 1; j++)
                    {
                        productList[j] = productList[j + 1];
                    }
                }
            }
            size--;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < productList.Length - 1; i++)
            {
                productList[i] = productList[i + 1];
            }
            size--;
        }
    }
}