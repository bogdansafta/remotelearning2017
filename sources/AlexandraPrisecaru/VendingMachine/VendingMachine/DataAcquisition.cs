using System;
using System.IO;
using System.Linq;

namespace VendingMachine
{
    public class DataAcquisition
    {
        private static DataAcquisition instance;
        private const string csvSalesFile = "Data/Sales.csv";
        private const string csvStocksFile = "Data/Stocks.csv";
        private const string csvVolumesFile = "Data/Volumes.csv";


        public static DataAcquisition Instance => instance ?? (instance = new DataAcquisition());

        private List<Sale> sales;
        private List<Volume> volumes;
        private List<Stock> stocks;

        private DataAcquisition()
        {
            sales = new List<Sale>();
            volumes = new List<Volume>();
            stocks = new List<Stock>();
        }

        public void AddToSales(Product product)
        {
            Sale sale = new Sale(product);
            sales.Add(sale);
            AddToVolumes(product.Name, 1);
            UpdateStock(product.Name, 1);

            File.AppendAllText(csvSalesFile, sale.ToString());
        }

        public void AddToStocks(string productName, int quantity)
        {
            Stock stock = stocks.FirstOrDefault(s => s.ProductName.Equals(productName));
            if (stock == null)
            {
                stock = new Stock(productName, quantity);
                stocks.Add(stock);
                File.AppendAllText(csvStocksFile, stock.ToString());
            }
            else
            {
                stock.Quantity += quantity;
            }
        }

        public void UpdateStock(string productName, int quantity)
        {
            Stock stock = stocks.FirstOrDefault(s => s.ProductName.Equals(productName));
            if (stock == null)
            {
                AddToStocks(productName, quantity);
            }
            else
            {
                stock.Quantity -= quantity;
            }
        }

        public void AddToVolumes(string productName, int quantity)
        {
            Volume volume = volumes.FirstOrDefault(v => v.ProductName.Equals(productName));
            if (volume == null)
            {
                volume = new Volume(productName, quantity);
                volumes.Add(volume);
                File.AppendAllText(csvVolumesFile, volume.ToString());
            }
            else
            {
                volume.TotalQuantity += quantity;
            }
        }

        private class Sale
        {
            public string ProductName { get; }
            public int Quantity { get; }
            public double Price { get; }
            public DateTime Date { get; }

            public Sale(Product product)
            {
                ProductName = product.Name;
                Quantity = product.Quantity;
                Price = product.Price;
                Date = DateTime.Now;
            }

            public override string ToString()
            {
                return $"{ProductName}, {Price}, {Quantity}, {Date}\n";
            }
        }

        private class Volume
        {
            public string ProductName { get; }
            public int TotalQuantity { get; set; }

            public Volume(string productName, int quantity)
            {
                ProductName = productName;
                TotalQuantity += quantity;
            }

            public override string ToString()
            {
                return $"{ProductName},{TotalQuantity}\n";
            }
        }

        private class Stock
        {
            public string ProductName { get; }
            public int Quantity { get; set; }

            public Stock(string productName, int quantity)
            {
                ProductName = productName;
                Quantity = quantity;
            }

            public override string ToString()
            {
                return $"{ProductName},{Quantity}\n";
            }
        }
    }
}
