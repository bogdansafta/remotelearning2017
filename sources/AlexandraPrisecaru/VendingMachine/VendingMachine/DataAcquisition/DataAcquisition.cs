using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

namespace VendingMachine
{
    public class DataAcquisition : IPaymentListener
    {
        private static readonly object padlock = new object();
        private static DataAcquisition instance;
        public static DataAcquisition Instance
        {
            get
            {

                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataAcquisition();
                    }
                    return instance;
                }
            }
        }

        public ObservableCollection<Sale> Sales { get; private set; }

        public System.Collections.Generic.List<Volume> Volumes { get; private set; }
        public System.Collections.Generic.List<Stock> Stocks { get; private set; }

        private void SalesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action != NotifyCollectionChangedAction.Add) return;

            Sale sale = ((ObservableCollection<Sale>)sender)?.Last();
            if (sale == null) return;

            AddToVolumes(sale.ProductName, sale.Quantity);
            DecreaseFromStock(sale.ProductName, sale.Quantity);
        }

        private DataAcquisition()
        {
            Sales = new ObservableCollection<Sale>();
            Sales.CollectionChanged += SalesChanged;

            Volumes = new System.Collections.Generic.List<Volume>();
            Stocks = new System.Collections.Generic.List<Stock>();
        }

        public void AddToStocks(string productName, int quantity)
        {
            Stock stock = Stocks.FirstOrDefault(s => s.ProductName.Equals(productName));
            if (stock == null)
            {
                stock = new Stock(productName, quantity);
                Stocks.Add(stock);
            }
            else
            {
                stock.Quantity += quantity;
            }
        }

        public void DecreaseFromStock(string productName, int quantity)
        {
            Stock stock = Stocks.FirstOrDefault(s => s.ProductName.Equals(productName));
            if (stock == null)
            {
                throw new ProductNotFoundException();
            }
            stock.Quantity -= quantity;
        }

        public void AddToVolumes(string productName, int quantity)
        {
            Volume volume = Volumes.FirstOrDefault(v => v.ProductName.Equals(productName));
            if (volume == null)
            {
                volume = new Volume(productName, quantity);
                Volumes.Add(volume);
            }
            else
            {
                volume.TotalQuantity += quantity;
            }
        }

        public void Update(int idProduct)
        {
            Product product = VendingMachine.Instance.Items.FirstOrDefault(item => item.Position.Id == idProduct).Product;
            if (product == null)
            {
                throw new ProductNotFoundException();
            }

            Sales.Add(new Sale(product));
        }
    }
}
