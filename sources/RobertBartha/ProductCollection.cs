using System;

namespace Product___ProductCollection
{
    class ProductCollection<Tip>
    {
        public int Count;
        private Nod<Tip> start;
        private Nod<Tip> sfarsit;
        public ProductCollection()
        {
            start = null;
        }
        public void Add(Tip Produs)
        {
            if (start == null)
            {
                Count++;
                start = new Nod<Tip>();
                start.data = Produs;
                sfarsit = start;

            }
            else
            {
                Count++;
                Nod<Tip> adaugareNod = new Nod<Tip>();
                adaugareNod.data = Produs;
                sfarsit.urmator = adaugareNod;
                sfarsit = adaugareNod;
            }
        }
        public void Remove(Tip Produs)
        {
            Nod<Tip> pozProdus = start;
            if (start.data.Equals(Produs))
            {
                start = start.urmator;
                Count--;
            }
            else
            if (sfarsit.data.Equals(Produs))
            {
                while (pozProdus.urmator != sfarsit)
                {
                    pozProdus = pozProdus.urmator;
                }
                pozProdus.urmator = null;
                sfarsit = pozProdus;
                Count--;
            }
            else
            {
                Nod<Tip> pozActuala = new Nod<Tip>();
                pozActuala = pozProdus.urmator;
                while (pozActuala != null)
                {
                    if (pozActuala.data.Equals(Produs))
                    {
                        pozActuala = pozActuala.urmator;
                        Count--;
                    }
                    pozProdus = pozActuala;
                }
            }
        }
        public Tip GetItem(int num)
        {
            Nod<Tip> getNod = start;
            for (int i = 0; i < num; i++)
            {
                getNod = getNod.urmator;
            }
            return getNod.data;
        }

    }
}