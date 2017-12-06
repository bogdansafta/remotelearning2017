using System;

namespace Products
{
    public class ProductCollection 
    {
        private int size;

        private Product[] productList;

        public ProductCollection()
        {
            size = 0;
            productList = new Product[size + 1];
        }

        public void AddProduct(Product product)
        {
            Product[] auxiliaryList = productList;
            productList = new Product[size + 1];

            for (int i = 0; i < auxiliaryList.Length; i++)
            {
                productList[i] = auxiliaryList[i];
            }

            productList[size] = product;
            size++;
        }

        public Product GetItem(int index)
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

        public void Remove(Product product)
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
    }
}