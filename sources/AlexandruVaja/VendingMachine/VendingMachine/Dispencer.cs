using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Dispencer
    {
        public ContainableItemCollection dispensedProduct;

        public Dispencer()
        {
            dispensedProduct = new ContainableItemCollection();
        }

        public Dispencer (ContainableItemCollection dispensedProduct)
        {
            this.dispensedProduct = dispensedProduct;
        }

        public Product Dispense(int id)
        {
            if (id <= 0)
                throw new System.Exception("Invalid position!");
            Product product = dispensedProduct.GetProductByID(id);
            return product;
        }

        public Product Get(int id)
        {
            return dispensedProduct.GetProductByID(id);
        }
    }
}
