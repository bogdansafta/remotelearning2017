using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using VendingMachine;

public sealed class Data : IPaymentListener
{
    private static Data instance = null;
    private static readonly object Padlock = new object();
    public List<Sale> Sales = new List<Sale>();
    public List<Stock> Stocks = new List<Stock>();
    public List<Volume> Volumes = new List<Volume>();
    private ContainableItemsCollection collection;

    internal ContainableItemsCollection Collection { get => collection; set => collection = value; }

    Data()
    {
    }

    public static Data Instance
    {
        get
        {
            lock (Padlock)
            {
                if (instance == null)
                {
                    instance = new Data();
                }
                return instance;
            }
        }
    }

    public void Update(int id)
    {
        Product product = collection.GetProductViaID(id);
        Sale sale = Search<Sale>(new Sale(), product);
        if (sale == null)
        {
            sale = new Sale(product, DateTime.Now);
            Sales.Add(sale);
        }
        else
        {
            sale.Quantity++;
        }
        Volume volume = Search<Volume>(new Volume(), product);
        AddToStocks(product, volume.Quantity);
    }

    private T Search<T>(T type, Product product)
    {
        if (type.GetType().ToString() == "VendingMachine.Volume")
        {
            type = (T)(object)Volumes.FirstOrDefault((s => s.ProductName.Equals(product.GetName()) && s.ProductCategory.Equals(product.GetCategory())));
        }
        else if (type.GetType().ToString() == "VendingMachine.Sale")
        {
            type = (T)(object)Sales.FirstOrDefault((s => s.productName.Equals(product.GetName()) && s.ProductCategory.Equals(product.GetCategory())));
        }
        else if (type.GetType().ToString() == "VendingMachine.Stock")
        {
            type = (T)(object)Stocks.FirstOrDefault((s => s.ProductName.Equals(product.GetName()) && s.ProductCategory.Equals(product.GetCategory())));
        }
        return type;
    }

    public void AddToVolumes(Product product, int quantity)
    {
        Volume volume = Search<Volume>(new Volume(), product);
        if (volume == null)
        {
            Volumes.Add(new Volume(product.GetName(), product.GetCategory(), quantity, DateTime.Now));
        }
        else
        {
            volume.Quantity += quantity;
        }
    }

    private void AddToStocks(Product product, int quantity)
    {
        Stock stock = Search<Stock>(new Stock(), product);
        if (stock == null)
        {
            Stocks.Add(new Stock(product.GetName(), product.GetCategory(), quantity - 1, DateTime.Now));
        }
        else
        {
            stock.Quantity--;
        }
    }

    public void WritingCsv()
    {
        String data = $" From Date {DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}";
        Console.WriteLine(data);
        foreach (Sale x in Sales)
        {
            File.AppendAllText($"Data/Sales{data}.csv", x.ToString());
        }
        foreach (Volume x in Volumes)
        {
            File.AppendAllText($"Data/Volumes{data}.csv", x.ToString());
        }
        CompletingStocks();
        foreach (Stock x in Stocks)
        {
            File.AppendAllText($"Data/Stocks{data}.csv", x.ToString());
        }
    }
    public void CompletingStocks()
    {
        foreach (Volume x in Volumes)
        {
            Stock stock = Search<Stock>(new Stock(), new Product(x.ProductCategory, x.ProductName, 0, 0));
            if (stock == null)
            {
                Stocks.Add(new Stock(x.ProductName, x.ProductCategory, x.Quantity, DateTime.Now));
            }
        }
    }
}