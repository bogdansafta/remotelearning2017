using System;

namespace VendingMachine
{
    internal class Product
    {
        private ProductCategory category;
        private string name;
        public double price;
        private int size;
        public Product()
        {
            category = null;
            name = null;
            price = 0;
            SetSize(0);
        }
        public Product(String category, String name, double price, int quantity)
        {
            this.category = new ProductCategory(category);
            this.name = name;
            this.price = price;
            SetSize(quantity);
        }

        public override String ToString()
        {
            return (GetCategory() + " " + GetName() + "  Cantitate:" + GetSize() + " Pret:" + price);
        }
        public string GetCategory()
        {
            return category.name;
        }
        public void SetCategory(string value)
        {
            category.name = value;
        }
        public string GetName()
        {
            return name;
        }
        private void SetName(string value)
        {
            name = value;
        }
        public int GetSize()
        {
            return size;
        }
        public void SetSize(int value)
        {
            size = value;
        }

        public bool Equals(Product other)
        {
            if (name == other.name && category.name == other.category.name)
                return true;
            else
                return false;
        }
    }
}