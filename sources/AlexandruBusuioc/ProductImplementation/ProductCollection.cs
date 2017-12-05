using System;
using System.Collections;
namespace ProductImplementation
{
    public class ProductCollection
    {
        private Node head;
        private Node current;
        private int count = -1;
        public int Count
        {
            get
            {
                return count + 1;
            }
        }
        public void Add(Product added)
        {
            if (head == null)
            {
                head = new Node();
                head.next = null;
                head.product = added;
                current = head;
            }
            else
            {
                Node newNode = new Node();
                newNode.product = added;
                newNode.next = null;
                current.next = newNode;
                current = newNode;
            }
            count++;
        }
        public void Remove(Product removed)
        {
            Node item = head;
            Node prev = new Node();

            if (count <= -1)
                throw new NullReferenceException();

            if (removed.Equals(head.product))
            {
                head = head.next;
                count--;
                return;
            }

            if (removed.Equals(current.product))
            {
                current = item;
                current.next = null;
                count--;
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (!item.product.Equals(removed))
                {
                    prev = item;
                    item = item.next;
                }
                else
                {
                    prev.next = item.next;
                    count--;
                    break;
                }
            }
        }
        public Product GetItem(int index)
        {
            if (count <= -1)
                throw new NullReferenceException();
            if (index > count)
                throw new ArgumentOutOfRangeException();

            Node item = head;

            if (index == 0)
                return head.product;

            if (index == count)
                return current.product;

            for (int i = 0; i < index; i++)
                item = item.next;

            if (item == null)
                throw new Exception("Element not found!");
            else
                return item.product;

        }

        public Product this[int index]
        {
            get
            {
                return GetItem(index);
            }
        }
    }
}
