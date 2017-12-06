using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> current;
        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }

        public LinkedList()
        {
            head = new Node<T>();
            current = head;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            if (head.Value == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.Next = newNode;
                current = newNode;
            }

            size++;
        }

        public void AddAtStart(T data)
        {
            Node<T> newNode = new Node<T>() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            size++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                size--;
            }
            else
            {
                throw new Exception("No element exist in this linked list.");
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                head = null;
                current = null;
                return;
            }

            if (index > 1 && index <= size)
            {
                Node<T> tempNode = head;
                Node<T> lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == index - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        size--;
                        return;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
        }

        public T GetItem(int index)
        {
            if (index > 0 && index < size)
            {
                Node<T> tempNode = head;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == index - 1)
                    {
                        return tempNode.Next.Value;
                    }

                    count++;
                    tempNode = tempNode.Next;
                }
            }
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        internal class Enumerator : IEnumerator<T>
        {
            private LinkedList<T> list;
            private int index;
            private Node<T> node;
            private T current;

            internal Enumerator(LinkedList<T> list)
            {
                this.list = list;
                index = 0;
                node = list.head;
                current = default(T);
            }

            public T Current
            {
                get
                {
                    return current;
                }
            }

            object IEnumerator.Current { get { return Current; } }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (node == null)
                {
                    index = list.Count + 1;
                    return false;
                }

                ++index;
                current = node.Value;
                node = node.Next;
                if (node == list.head)
                {
                    node = null;
                }
                
                return true;
            }

            public void Reset()
            {
                index = 0;
                current = default(T);
            }
        }
    }
}