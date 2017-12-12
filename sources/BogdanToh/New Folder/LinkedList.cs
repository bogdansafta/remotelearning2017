using System;
using System.Collections;
using System.Collections.Generic;

namespace New_Folder
{
    class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> lastNode;
        public int Count { get; private set; }

        public LinkedList()
        {
            head = null;

        }

        public void Add(T obj)
        {
            if (head == null)
            {
                head = new Node<T>();
                head.data = obj;
                lastNode = head;
                Count++;
            }
            else
            {
                Node<T> addNode = new Node<T>();
                addNode.data = obj;
                lastNode.next = addNode;
                lastNode = addNode;
                Count++;
            }


        }

        public void Remove(T obj)
        {

            Node<T> findObj = head;
            if (head.data.Equals(obj))
            {

                head = head.next;
                Count--;
            }
            else if (lastNode.data.Equals(obj))
            {

                while (findObj.next != lastNode)
                    findObj = findObj.next;
                findObj.next = null;
                lastNode = findObj;
                Count--;

            }
            else
            {

                while (findObj.next != null)
                {

                    if (findObj.next.data.Equals(obj))
                    {

                        findObj.next = findObj.next.next;
                        Count--;
                        break;
                    }
                    findObj = findObj.next;

                }
            }
        }

     
        public T GetItem(int index)
        {
            Node<T> getNode = head;
            if (index < 0 || index > Count - 1)
                throw new ArgumentOutOfRangeException();
            for (int i = 0; i < index; i++)
            {
                getNode = getNode.next;

            }

            return getNode.data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");

            }
            Node<T> iterator = head;
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
