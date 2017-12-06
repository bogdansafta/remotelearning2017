using System;

namespace VendingMachine
{
    class ProductStack
    {
        private Product thisProduct = null;
        private ProductStack nextProduct = null;

        public Product ThisProduct {
            get {
                return thisProduct;
            }
            set {
                thisProduct = value;
            }
        }

        public ProductStack NextProduct {
            get {
                return nextProduct;
            }
            set {
                nextProduct = value;
            }
        }

        public ProductStack(Product product)
        {
            thisProduct = product;
        }
    }
}
