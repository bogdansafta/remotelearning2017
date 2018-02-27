using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine;

public sealed class Data
{
    private static Data instance = null;
    private static List<Sale> Sales=new List<Sale>();
    private static readonly object padlock = new object();

    Data()
    {
    }

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
    public void SetData(Product product, DateTime dateTime)
    {
        Sales.Add(new Sale(product,dateTime));
    }
    public override String ToString()
    {
        StringBuilder stringBuilder=new StringBuilder();
        foreach(Sale x in Sales)
        {
            stringBuilder.Append(x.ToString()+"\n");
        }
        return stringBuilder.ToString();
    }
}