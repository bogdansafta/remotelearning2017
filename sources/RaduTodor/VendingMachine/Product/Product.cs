using System;

namespace VendingMachine
{
    public class Product
    {
        private ProductCategory category;
        private string name;
        public double Price;
        private int size;

        public Product()
        {
            category = null;
            name = null;
            Price = 0;
            SetSize(0);
        }

        public Product(String category, String name, double price, int quantity)
        {
            this.category = new ProductCategory(category);
            this.name = name;
            this.Price = price;
            SetSize(quantity);
        }

        public override String ToString()
        {
            return (GetCategory() + " " + GetName() + "  Cantitate:" + GetSize() + " Pret:" + Price);
        }

        public string GetCategory()
        {
            return category.Name;
        }

        public void SetCategory(string value)
        {
            category.Name = value;
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
            if (name == other.name && category.Name == other.category.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}