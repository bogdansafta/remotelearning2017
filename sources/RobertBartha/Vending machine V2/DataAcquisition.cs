using System;
using System.Collections.Generic;
using System.Text;
namespace Vending_machine_V2
{
    public class Data
    {
        private static Data instance = null;
        private static List<Sale> sales = new List<Sale>();
        private static readonly object padlock = new object();
        public static Data Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Data();
                    }
                    return instance;
                }
            }
        }
        public void SetData(Product product, DateTime date)
        {
            sales.Add(new Sale(product, date));
        }
        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Sale s in sales)
            {
                stringBuilder.Append(s.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}