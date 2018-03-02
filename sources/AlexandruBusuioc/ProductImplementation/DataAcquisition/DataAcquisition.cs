using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProductImplementation
{
    public class DataAcquisition : IPaymentListener
    {
        private static DataAcquisition instance;
        private List<Sales> sales = new List<Sales>();
        private List<Stock> stock = new List<Stock>();
        private List<Stock> volume = new List<Stock>();

        private ContainableItemsCollection collection;
        private DataAcquisition(){}

        public static DataAcquisition Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAcquisition();
                }
                return instance;
            }
        }

        public void UpdateStock()
        {
            if (stock.Count <= 0)
            {
                for (int index = 0; index < collection.Count; index++)
                {
                    Stock element = new Stock(collection[index].product.Name, collection[index].product.Quantity);
                    volume.Add(element);
                }
            }
            for (int index = 0; index < collection.Count; index++)
            {
                Stock element = new Stock(collection[index].product.Name, collection[index].product.Quantity);
                Stock replacement = stock.FirstOrDefault(x => x.Name == element.Name);
                System.Console.WriteLine(replacement);
                if (replacement != null)
                {
                    replacement.Quantity = element.Quantity;
                    stock.Remove(element);
                    stock.Add(replacement);
                }
                else
                {
                    stock.Add(element);
                }
            }
            stock = stock.Distinct().ToList();
        }

        public void Update(int id)
        {
            Product product = collection.FindByID(id).product;
            Sales sale = new Sales(product.Name,1,product.Price);
            sales.Add(sale);
            UpdateStock();
        }
        public string CSVGenerator<T>(StringBuilder builder, List<T> list)
        {
            foreach (var item in list)
            {
                builder.Append(item.ToString()).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        public void ExportToCSV()
        {
            string directory = Directory.GetCurrentDirectory();
            File.WriteAllText($@"{directory}\Data\volume.csv", CSVGenerator(new StringBuilder(),volume));
            File.WriteAllText($@"{directory}\Data\stock.csv", CSVGenerator(new StringBuilder(),stock));
            File.WriteAllText($@"{directory}\Data\sales.csv", CSVGenerator(new StringBuilder(),sales));
        }

        public void SetCollection(ContainableItemsCollection collection)
        {
            this.collection = collection;
            UpdateStock();
        }
    }
}