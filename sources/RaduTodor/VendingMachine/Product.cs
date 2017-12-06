using System;

namespace VendingMachine
{
    internal class Product: IEquatable<Product>
    {
        private string type;
        private string name;
        double Price { get; set; }
        private int quantity;
        private Tuple<int, int> size;
        public Product()
        {
            type = null;
            name = null;
            Price = 0;
            SetQuantity(0);
            SetSize(new Tuple<int, int>(0, 0));
        }
        public Product(String tip, String nume, double pret, int cantitate, int dimensiuneCelule1, int dimensiuneCelule2)
        {
            type = tip;
            name = nume;
            Price = pret;
            SetQuantity(cantitate);
            SetSize(new Tuple<int, int>(dimensiuneCelule1, dimensiuneCelule2));
        }
        
        public override String ToString()
        {
            return (Gettype() + " " + GetName() + " " + GetQuantity());
        }
        public string Gettype()
        {
            return type;
        }
        public void SetType(string value)
        {
            type = value;
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
        private Tuple<int, int> GetSize()
        {
            return size;
        }
        private void SetSize(Tuple<int, int> value)
        {
            size = value;
        }

        public bool Equals(Product other)
        {
            if ( name==other.name && type==other.type)
                return true;
            else 
                return false;
        }
    }
}