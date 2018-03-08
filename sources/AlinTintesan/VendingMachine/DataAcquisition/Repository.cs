using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace VendingMachine
{
    public sealed class Repository : IPaymentListener
    {
        private static Repository instance;

        private List<ActualStock> actualStock;
        private List<Sales> sales;
        private List<Volume> volume;

        private string salesFile="DataAcquisition/Sales.csv";
        private string actualStockFile="DataAcquisition/ActualStock.csv";
        private string volumeFile="DataAcquisition/Volume.csv";

        private Repository()
        {
            this.actualStock=new List<ActualStock>();
            this.sales=new List<Sales>();
            this.volume=new List<Volume>();
        }

        public static Repository Instance
        {
            get
            {
                if (instance == null)
                    instance = new Repository();
                return instance;
            }
        }

        public void Update(Product product)
        {
            this.sales.Add(new Sales(product));
            ActualStock soldProductStock = new ActualStock(product);
            foreach(var stock in this.actualStock)
                if(stock.Equals(soldProductStock))
                {
                    stock.CurrentStock--;
                    break;
                }
        }

        public void UpdateStockAndVolume(ContainableItemsCollection collection)
        {
            for(int index=0; index<collection.Count(); index++)
            {
                this.actualStock.Add(new ActualStock(collection.Get(index).Product));
                this.volume.Add(new Volume(collection.Get(index).Product, collection.Get(index).Product.Quantity));
            }
        }

        private void writeSells()
        {
            string delimiter=",";
            StringBuilder sellsReport=new StringBuilder();
            foreach(var entry in this.sales)
            {
                sellsReport.AppendLine(String.Join(delimiter,entry.ToString()));
            }
            File.AppendAllText(this.salesFile,sellsReport.ToString());
        }

        private void writeActualStock()
        {
            string delimiter=",";
            StringBuilder actualStockReport=new StringBuilder();
            foreach(var entry in this.actualStock)
            {
                actualStockReport.AppendLine(String.Join(delimiter,entry.ToString()));
            }
            File.AppendAllText(this.actualStockFile,actualStockReport.ToString());
        }

        private void writeVolume()
        {
            string delimiter=",";
            StringBuilder volumeReport=new StringBuilder();
            foreach(var entry in this.volume)
            {
                volumeReport.AppendLine(String.Join(delimiter,entry.ToString()));
            }
            File.AppendAllText(this.volumeFile,volumeReport.ToString());
        }

        public void writeReport()
        {
            this.writeSells();
            this.writeActualStock();
            this.writeVolume();
        }
    }
}