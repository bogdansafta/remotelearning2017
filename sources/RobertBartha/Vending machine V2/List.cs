using System;
using System.Collections;
using System.Collections.Generic;
namespace Vending_machine_V2
{
    public class List<Tip> : IEnumerable<Tip>
    {
        public int count { get; set; }
        private Nod<Tip> start;
        private Nod<Tip> end;
        public List()
        {
            start = null;
        }
        public Tip GetItem(int num)
        {
            Nod<Tip> getNod = start;
            for (int i = 0; i < num; i++)
            {
                getNod = getNod.next;
            }
            return getNod.data;
        }
        public void Add(Tip product)
        {
            if (start == null)
            {
                start = new Nod<Tip>();
                start.data = product;
                end = start;

            }
            else
            {
                Nod<Tip> addNod = new Nod<Tip>();
                addNod.data = product;
                end.next = addNod;
                end = addNod;
            }
            count++;
        }
        public void Remove(Tip product)
        {
            Nod<Tip> productPosition = start;
            if (start.data.Equals(product))
            {
                start = start.next;
                count--;
            }
            else
            if (end.data.Equals(product))
            {
                while (productPosition.next != end)
                {
                    productPosition = productPosition.next;
                }
                productPosition.next = null;
                end = productPosition;
                count--;
            }
            else
            {
                Nod<Tip> currentPosition = new Nod<Tip>();
                currentPosition = productPosition.next;
                while (currentPosition != null)
                {
                    if (currentPosition.data.Equals(product))
                    {
                        currentPosition = currentPosition.next;
                        count--;
                    }
                    productPosition = currentPosition;
                }
            }
        }
        public IEnumerator<Tip> GetEnumerator()
        {
            if (start == null)
            {
                Console.WriteLine("Empty List");

            }
            Nod<Tip> iterator = start;
            while (iterator != null)
            {
                yield return iterator.data;
                iterator = iterator.next;
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}