using System.IO;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine
    {
        private static readonly object padlock = new object();
        private static VendingMachine instance;
        private ContainableItemCollection items;

        public static VendingMachine Instance
        {

            get
            {

                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new VendingMachine();
                    }
                    return instance;
                }
            }
        }

        public ContainableItemCollection Items
        {
            get
            {
                if (items == null)
                {
                    items = GetInitializedCollection();
                }
                return items;
            }
        }

        private VendingMachine() { }

        private ContainableItemCollection GetInitializedCollection()
        {
            string[] containableItems = File.ReadAllLines("Data/Products.csv").Skip(1).ToArray();
            ContainableItemCollection collection = new ContainableItemCollection();
            foreach (var item in containableItems)
            {
                string[] values = item.Split(",");

                int.TryParse(values[0], out int row);
                int.TryParse(values[1], out int column);
                int.TryParse(values[2], out int id);
                int.TryParse(values[3], out int size);
                string productName = values[4];
                double.TryParse(values[5], out double price);
                int.TryParse(values[6], out int quantity);

                collection.Add(new ContainableItem()
                {
                    Position = new Position(row, column, id, size),
                    Product = new Product()
                    {
                        Name = productName,
                        Price = price,
                        Quantity = quantity
                    }
                });

                DataAcquisition.Instance.AddToStocks(productName, quantity);
            }

            collection.Add(new ContainableItem()
            {
                Product = new Product() { Name = "snacks, snacks & snacks", Quantity = 10 }
            });
            
            DataAcquisition.Instance.AddToStocks("snacks, snacks & snacks", 10);

            return collection;
        }
    }
}