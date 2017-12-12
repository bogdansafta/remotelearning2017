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
            float totalTimeAutoProperty = 0;
            float totalTimeProperty = 0;
            float totalTimeField = 0;
            double d;

            for (int j = 0; j < 10; j++)
            {
                List<AutoPropertyClass> autpPropertyObjects = new List<AutoPropertyClass>(NumberOfIterations);
                List<PropertyClass> propertyObjects = new List<PropertyClass>(NumberOfIterations);
                List<FieldClass> fieldObjects = new List<FieldClass>(NumberOfIterations);

                // Create NumberOfIterations object with random numbers.

                Random r = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < NumberOfIterations; i++)
                {
                    double p = r.NextDouble();
                    autpPropertyObjects.Add(new AutoPropertyClass() { P = p });
                    propertyObjects.Add(new PropertyClass() { P = p });
                    fieldObjects.Add(new FieldClass() { P = p });
                }

                // Read the numbers from the auto-property classes.

                Stopwatch Timer = new Stopwatch();
                d = 0.0;
                Timer.Restart();

                for (int i = 0; i < NumberOfIterations; i++)
                {
                    d += autpPropertyObjects[i].P;
                }

                Timer.Stop();
                long autoPropertyTime = Timer.ElapsedTicks;

                // Read the numbers from property classes

                Timer.Restart();
                d = 0;

                for (int i = 0; i < NumberOfIterations; i++)
                {
                    d += propertyObjects[i].P;
                }

                Timer.Stop();
                long propertyTime = Timer.ElapsedTicks;

                // Read the numbers from field classes

                Timer.Restart();
                d = 0;

                for (int i = 0; i < NumberOfIterations; i++)
                {
                    d += fieldObjects[i].P;
                }

                Timer.Stop();
                long fieldTime = Timer.ElapsedTicks;

                // Display results.

                totalTimeAutoProperty += autoPropertyTime;
                totalTimeProperty += propertyTime;
                totalTimeField += fieldTime;
                Console.WriteLine($"Results: AutoProperty: {autoPropertyTime}; Property: {propertyTime}; Field: {fieldTime}");
            }

            Console.WriteLine();
            Console.WriteLine($"Ticks for AutoProperty: {totalTimeAutoProperty}");
            Console.WriteLine($"Ticks for Property: {totalTimeProperty}");
            Console.WriteLine($"Ticks for Field: {totalTimeField}");
            Console.WriteLine();

            // double percent = 100 - ((totalTimeAutoProperty / totalTimeProperty) * 100);
            // Console.WriteLine($"Property is {percent}% faster than Field on the average of 10 Iterations.");
        }
    }
}