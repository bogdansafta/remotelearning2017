using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VendingMachine
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private static List<Sales> salesList = new List<Sales>();
        private static List<Volume> volumesList = new List<Volume>();
        private static List<Stock> stocksList = new List<Stock>();



        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

         public void CollectSalesData(Product product, DateTime dateTime)
         {
             product.Quantity--;
             salesList.Add(new Sales(product, dateTime));
         }

        public void CollectVolumesData(Product product)
        {
            volumesList.Add(new Volume(product.Name, product.Quantity, DateTime.Now));
        }

        public void CollectStocksData(Product product)
        {
            stocksList.Add(new Stock(product.Name, product.Quantity, DateTime.Now));
        }

        public void WriteCsvSale()
        {
            string delimiter = ",";
            StringBuilder saleCsv = new StringBuilder();

            foreach (Sales sale in salesList)
            {
                saleCsv.AppendLine(String.Join(delimiter, sale.ToString()));
            }

            File.AppendAllText("DataAcquisition/Sale.csv", saleCsv.ToString());
        }

        public void WriteCsvVolume()
        {
            string delimiter = ",";
            StringBuilder volumeCsv = new StringBuilder();

            foreach (Volume volume in volumesList)
            {
                volumeCsv.AppendLine(String.Join(delimiter, volume.ToString()));
            }

            File.AppendAllText("DataAcquisition/Volume.csv", volumeCsv.ToString());
        }

        public void WriteCsvStock()
        {
            string delimiter = ",";
            StringBuilder stockCsv = new StringBuilder();

            foreach (Stock stock in stocksList)
            {
                stockCsv.AppendLine(String.Join(delimiter, stock.ToString()));
            }

            File.AppendAllText("DataAcquisition/Stock.csv", stockCsv.ToString());
        }

        public void WriteReport()
        {
            WriteCsvSale();
            WriteCsvVolume();
            WriteCsvStock();
        }
    }
}