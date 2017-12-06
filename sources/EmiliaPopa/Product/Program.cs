using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {    Collection prod = new Collection();
            Products p = new Products("nume", "tip", 2, 3, 12);
            Products p2 = new Products("nume2", "tip", 4, 5, 15);
            Products p3= new Products("nume3", "tip", 3, 6, 29);
             prod.add(p);
             prod.add(p2);
             prod.add(p3);
             
                    prod.remove(p);
            
            for (int i = 0; i < prod.Size; i++)
                    Console.WriteLine(prod.getItem(i).Name);

        }
    }
}
