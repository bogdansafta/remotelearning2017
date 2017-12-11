using System;

namespace Product___ProductCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection<ContainableItem> lista = new ProductCollection<ContainableItem>();
            Position poz = new Position(1, 1, 2);
            Product produs = new Product(poz, "Ciocolata", 1, "Milka", 12, 1);
            lista.Add(produs);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista);
            }
            lista.Remove(produs);
        }
    }
}
