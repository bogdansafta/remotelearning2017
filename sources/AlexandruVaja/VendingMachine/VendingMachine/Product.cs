using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Product : ContainableItem, IEquatable<Product>
    {
        public string TypeProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public int QuantityProduct { get; set; }
 

        public Product()
        {
            TypeProduct = null;
            NameProduct = null;
            PriceProduct = 0.0;
            QuantityProduct = 0;

        }

        public Product(string newTypeProduct, string newNameProduct, double newPriceProduct, int newQuantityProduct)
        {
            this.TypeProduct = newTypeProduct;
            this.NameProduct = newNameProduct;
            this.PriceProduct = newPriceProduct;
            this.QuantityProduct = newQuantityProduct;
        }

        public override String ToString() => $"TypeProduct = {TypeProduct} NameProduct = {NameProduct} PriceProduct = {PriceProduct} QuantityProduct = {QuantityProduct}";

        public bool Equals(Product other)
        {
            if (!TypeProduct.Equals(other.TypeProduct))
                return false;
            if (!NameProduct.Equals(other.NameProduct))
                return false;
            if (!PriceProduct.Equals(other.PriceProduct))
                return false;
            if (!QuantityProduct.Equals(other.QuantityProduct))
                return false;
            return true;
        }
    }
}
