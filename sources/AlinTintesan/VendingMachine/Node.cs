using System;

namespace VendingMachine
{
    public class Node<Type>
    {
        public Type data {get;set;}
        public Node<Type> next;
    }
}