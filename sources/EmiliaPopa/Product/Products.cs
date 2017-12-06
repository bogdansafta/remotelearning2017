using System;

namespace Product
{
    internal class Products: IEquatable<Products>
    {
      public string Name
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
        public int Size
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }
        public float Price
        {
            get;
            set;
        }
        public Products()
        {
            Name = null;
            Type = null;
            Size = 0;
            Quantity = 0;
            Price = 0;

        }
        public Products(string name,string type, int size, int quantity, float price)
        {
            Name = name;
            Type = type;
            Size = size;
            Quantity = quantity;
            Price = price;
        }

        bool IEquatable<Products>.Equals(Products other)
        {
            if (this.Name == other.Name && this.Type == other.Type && this.Size == other.Size && this.Quantity == other.Quantity && this.Price == other.Price)
                return true;
            return false;
                }
    }

    }
