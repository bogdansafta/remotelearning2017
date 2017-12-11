using System;

namespace VendingMachine
{
    internal class Product : IEquatable<Product>
    {
        private ProductCategory category;
        private string name;
        double Price { get; set; }
        private int quantity;
        public Product()
        {
            category = null;
            name = null;
            Price = 0;
            SetQuantity(0);
        }
        public Product(String tip, String nume, double pret, int cantitate)
        {
            category = new ProductCategory(tip);
            name = nume;
            Price = pret;
            SetQuantity(cantitate);
        }

        public override String ToString()
        {
            return (Gettype() + " " + GetName() + " " + GetQuantity());
        }
        public string Gettype()
        {
            return category.Name1;
        }
        public void SetType(string value)
        {
            category.Name1 = value;
        }
        public string GetName()
        {
            return name;
        }
        private void SetName(string value)
        {
            name = value;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int value)
        {
            quantity = value;
        }

        public bool Equals(Product other)
        {
            if (name == other.name && category.Name1 == other.category.Name1)
                return true;
            else
                return false;
        }
    }
}