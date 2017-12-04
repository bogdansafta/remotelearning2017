using System;

namespace Product___ProductCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection<Product> lista = new ProductCollection<Product>();
            Product produs = new Product("Aliment", 1, "Ciocolata", 12, 1);
            lista.Add(produs);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista);
            }
            lista.Remove(produs);
        }
    }
}
