using System;

namespace VendingMachine
{
    internal class Product 
    {
        private ProductCategory Category;
        private string Name;
        float Price { get; set; }
        private int Size;
        public Product()
        {
            Category = null;
            Name = null;
            Price = 0;
            SetSize(0);
        }
        public Product(String category, String name, float price, int quantity)
        {
            Category = new ProductCategory(category);
            Name = name;
            Price = price;
            SetSize(quantity);
        }

        public override String ToString()
        {
            return (GetCategory() + " " + GetName() + "  Cantitate:" + GetSize()+ " Pret:"+ Price);
        }
        public string GetCategory()
        {
            return Category.name;
        }
        public void SetCategory(string value)
        {
            Category.name = value;
        }
        public string GetName()
        {
            return Name;
        }
        private void SetName(string value)
        {
            Name = value;
        }
        public int GetSize()
        {
            return Size;
        }
        public void SetSize(int value)
        {
            Size = value;
        }

        public bool Equals(Product other)
        {
            if (Name == other.Name && Category.name == other.Category.name)
                return true;
            else
                return false;
        }
    }
}