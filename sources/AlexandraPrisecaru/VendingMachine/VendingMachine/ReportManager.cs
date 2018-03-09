using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace VendingMachine
{
    public static class ReportManager<T>
    {
        internal static void GenerateReport(List<T> items)
        {
            StringBuilder stringbuilder = new StringBuilder();
            foreach (T item in items)
            {
                PropertyInfo[] properties = item.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    string propertyValue = property.GetValue(item).ToString();
                    stringbuilder.Append(propertyValue.Contains(",") ? $"\"{propertyValue}\"," : $"{propertyValue},");
                }
                stringbuilder.Append("\n");
            }

            File.WriteAllText($"Data/{typeof(T).Name}s.csv", stringbuilder.ToString());
        }
    }
}