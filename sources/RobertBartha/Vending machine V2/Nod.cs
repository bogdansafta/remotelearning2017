using System;

namespace Vending_machine_V2
{
    public class Nod<Tip>
    {
        public Tip data;
        public Nod<Tip> next;
    }
}