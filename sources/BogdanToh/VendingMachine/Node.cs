
using System;

namespace VendingMachine
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next;


    }
}
