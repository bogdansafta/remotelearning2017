using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VendingMachine
{
    class ContainableItemCollection<T> : ProductList<ContainableItem>
    {
        ProductList<ContainableItem> productList = new ProductList<ContainableItem>();

        public void Add(Product newProduct)
        {
            productList.Add(newProduct);
        }

        public void Remove(Product product)
        {
            productList.Remove(product);
        }

        public int Count() => productList.Count();

        public Product GetItem(int pozition)
        {
            return productList.GetItem(pozition) as Product;
        }
    }
}
