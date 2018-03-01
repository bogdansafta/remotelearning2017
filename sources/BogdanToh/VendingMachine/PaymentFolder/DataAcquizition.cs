using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace VendingMachine {
    public class DataAcquizition {
        //Sales -> product,quantity,price,value,date

        private int addToQuantity = 1;
        List<int> total = new List<int>();
        private static DataAcquizition data;

        private class Sales {

            private Product product;
            private DateTime time;
            public Sales (Product prod, DateTime time) {
                this.product = prod;
                this.time = time;
            }

            override
            public string ToString () {
                return $@"{product.ToString()} 
                       Date: {time.ToString()}";
            }

        }
        private class Volume {
            public string Name { get; private set; }
            public int TotalQuantity { get; private set; }
            public Volume (string name, int quantity) {
                this.Name = name;
                this.TotalQuantity = quantity;
            }
            override
            public string ToString () {
                return $"Name: {this.Name} , Total Quantity: {this.TotalQuantity}";

            }
        }
        private class Stock {
            private int quantity;
            private string name;
            public Stock (string name, int quantity) {
                this.name = name;
                this.quantity = quantity;
            }
            override
            public String ToString () {
                return $"Name: {this.name} , Quantity: {this.quantity}";
            }
        }
        List<Sales> sales = new List<Sales> ();
        List<Volume> volume = new List<Volume> ();
        List<Stock> stock = new List<Stock> ();
        private DataAcquizition () { }

        public void LoadData (Product product, DateTime time) {
            sales.Add (new Sales (product, time));
            stock.Add (new Stock (product.Name, product.Quantity));
            if (volume.Count > 1 && volume.ElementAt (volume.Count - 1).Name != product.Name) {
                addToQuantity = 1;
            }
            if (volume.Count == 1 && volume.ElementAt (volume.Count - 1).Name != product.Name) {
                addToQuantity = 1;
            }
            volume.Add (new Volume (product.Name, product.Quantity + addToQuantity));
            addToQuantity++;

        }
        public void ShowData () {
            Console.WriteLine ("Sales:");
            foreach (Sales s in sales)
                Console.WriteLine (s.ToString ());

            Console.WriteLine ("Volume:");
            foreach (Volume v in volume)
                Console.WriteLine (v.ToString ());

            Console.WriteLine ("Stock:");
            foreach (Stock st in stock) {
                Console.WriteLine (st.ToString ());
            }

            foreach(int t in total)
             Console.WriteLine ("ceva"+t);
        }
        public static DataAcquizition GetInstance () {
            if (data == null) {
                data = new DataAcquizition ();
            }
            return data;
        }
    }
}