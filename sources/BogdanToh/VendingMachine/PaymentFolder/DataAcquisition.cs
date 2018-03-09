using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace VendingMachine {
    public class DataAcquisition {
        //Sales -> product,quantity,price,value,date

        private int addToQuantity = 1;
        List<int> total = new List<int> ();
        private static DataAcquisition data;

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

        string salesCSV = "PaymentFolder/Sales.csv";
        string stockCSV = "PaymentFolder/Stock.csv";
        string volumeCSV = "PaymentFolder/Volume.csv";
        private DataAcquisition () { }

        public void LoadData (Product product, DateTime time) {
            sales.Add (new Sales (product, time));
            stock.Add (new Stock (product.Name, product.Quantity));
            if ((volume.Count > 1 || volume.Count == 1) && volume.ElementAt (volume.Count - 1).Name != product.Name) {
                addToQuantity = 1;
            }
            volume.Add (new Volume (product.Name, product.Quantity + addToQuantity));
            addToQuantity++;

        }

        private void SalesReport () {
            string delimiter = ";";
            StringBuilder report = new StringBuilder ();
            foreach (Sales s in sales) {
                report.AppendLine (String.Join (delimiter, s.ToString ()));
            }
            File.AppendAllText (this.salesCSV, report.ToString ());
        }


             private void StockReport()
       {
            string delimiter=";";
            StringBuilder report=new StringBuilder();
            foreach( Stock s in stock)
            {
                report.AppendLine(String.Join(delimiter,s.ToString()));
            }
            File.AppendAllText(stockCSV,report.ToString());
        }

         private void VolumeReport()
       {
            string delimiter=";";
            StringBuilder report=new StringBuilder();
            foreach( Volume v in volume)
            {
                report.AppendLine(String.Join(delimiter,v.ToString()));
            }
            File.AppendAllText(volumeCSV,report.ToString());
        }


        public void GenerateReports()
        {
            SalesReport();
            StockReport();
            VolumeReport();
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

        }
        public static DataAcquisition GetInstance () {
            if (data == null) {
                data = new DataAcquisition ();
            }
            return data;
        }
    }
}