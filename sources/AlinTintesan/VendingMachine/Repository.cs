using System;
using System.Text;

namespace VendingMachine
{
    public sealed class Repository
    {
        private static Repository instance;

        private StringBuilder report;
        private Repository() 
        { 
            this.report=new StringBuilder();
        }

        public static Repository Instance
        {
            get
            {
                if(instance==null)
                    instance=new Repository();
                return instance;
            }
        }

        public void writeReport(string productSold, StringBuilder currentStock)
        {
            report.Append(DateTime.Now.ToString());
            report.Append($" Product sold: {productSold}");
            report.AppendLine();
            report.Append(DateTime.Now.ToString());
            report.Append(" Current stock:");
            report.AppendLine();
            report.Append(currentStock);
            report.AppendLine();
        }

        public void printReport()
        {
            Console.WriteLine(this.report);
        }
    }
}