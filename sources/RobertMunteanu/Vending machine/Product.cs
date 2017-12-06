using System;

namespace VendingMachine
{
    class Product
    {  
        private string name;
        private float price;
        private int numberOfCells;
        private int quantity;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public float Price {
            get {
                return price;
            }
            set {
                price = value;
            }
        }

        public int NumberOfCells {
            get {
                return numberOfCells;
            }
            set {
                numberOfCells = value;
            }
        }

        public int Quantity {
            get {
                return quantity;
            }
            set {
                quantity = value;
            }
        }

        public Product(string name, float price, int numberOfCells, int quantity)
        {
            this.name = name;
            this.price = price;
            this.numberOfCells = numberOfCells;
            this.quantity = quantity;
        }

    }
}