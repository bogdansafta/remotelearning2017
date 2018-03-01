using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private static List<Sales> salesList = new List<Sales>();

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

        public void collectData(Product product, DateTime dateTime)
        {
            salesList.Add(new Sales(product, dateTime));
        }

        public override String ToString()
        {
            StringBuilder addSales = new StringBuilder();
            foreach (Sales sale in salesList)
            { 
                addSales.Append(sale);
            }
            return addSales.ToString();
        }
    }
}