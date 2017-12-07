using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Fields_vs_prop
{
    class Program
    {
        static int NumberOfIterations = 9999999;
        static void Main(string[] args)
        {
            float PropFin = 0;
            float FieldFin = 0;
            string report;
            double d;
            for (int j = 0; j < 10; j++)
            {
                List<PropertyClass> PropertyObj = new List<PropertyClass>(NumberOfIterations);
                List<FieldClass> FieldObj = new List<FieldClass>(NumberOfIterations);
                Random r = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < NumberOfIterations; i++)
                {
                    double p = r.NextDouble();
                    PropertyObj.Add(new PropertyClass() { P = p });
                    FieldObj.Add(new FieldClass() { P = p });
                }
                Stopwatch Timer = new Stopwatch();
                d = 0.0;
                Timer.Restart();
                for (int i = 0; i < NumberOfIterations; i++)
                {
                    d += PropertyObj[i].P;  
                }
                Timer.Stop();
                long x = Timer.ElapsedTicks;
                Timer.Restart();
                d = 0;
                for (int i = 0; i < NumberOfIterations; i++)
                {
                    d += FieldObj[i].P;
                }
                Timer.Stop();
                long y = Timer.ElapsedTicks;
                PropFin += x;
                FieldFin += y;
                report = $"Results\nProperty: {x}\nField: {y}\n";
                Console.WriteLine(report);
            }
            Console.WriteLine($"Ticks for Property: {PropFin}\nTicks for Field: {FieldFin}\n");
            Console.WriteLine($"Property is {-(((PropFin/FieldFin)*100)-100)}% faster than Field on the average of 10 Iterations");

        }
    }
}