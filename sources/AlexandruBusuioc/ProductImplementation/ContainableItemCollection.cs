using System;
using System.Collections;
namespace ProductImplementation
{
    public class ContainableItemsCollection
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
        public void Add(ContainableItem added)
        {
            if (head == null)
            {
                head = new Node();
                head.next = null;
                head.item = added;
                current = head;
            }
            else
            {
                Node newNode = new Node();
                newNode.item = added;
                newNode.next = null;
                current.next = newNode;
                current = newNode;
            }
            count++;
        }
        public void RemoveByPosition(Position pos)
        {
            Node temp = head;
            if (count <= -1)
                throw new NullReferenceException();
            if(temp.item.position.Equals(pos))
            {
                ContainableItem toDelete = temp.item;
                Remove(toDelete);
                return;
            }
            while(temp.next!=null)
            {
                if(temp.item.position.Equals(pos))
                {
                    ContainableItem toDelete = temp.item;
                    Remove(toDelete);
                }
                else
                {
                    temp = temp.next;
                }
            }
            if(temp == current && temp.item.position.Equals(pos))
            {
                ContainableItem toDelete = temp.item;
                Remove(toDelete);
            }
            else if(temp == current && !temp.item.position.Equals(pos))
                System.Console.WriteLine("Could not find item with specified position");

        }
        public void Remove(ContainableItem removed)
        {
            Node temp = head;
            Node prev = new Node();

            if (count <= -1)
                throw new NullReferenceException();

            if (removed.Equals(head.item))
            {
                head = head.next;
                count--;
                return;
            }

            if (removed.Equals(current.item))
            {
                current = temp;
                current.next = null;
                count--;
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (!temp.item.Equals(removed))
                {
                    prev = temp;
                    temp = temp.next;
                }
                else
                {
                    prev.next = temp.next;
                    count--;
                    break;
                }
            }
        }
        public ContainableItem GetItem(int index)
        {
            if (count <= -1)
                throw new NullReferenceException();
            if (index > count)
                throw new ArgumentOutOfRangeException();

            Node temp = head;

            if (index == 0)
                return head.item;

            if (index == count)
                return current.item;

            for (int i = 0; i < index; i++)
                temp = temp.next;

            if (temp == null)
                throw new Exception("Element not found!");
            else
                return temp.item;

        }

        public ContainableItem this[int index]
        {
            get
            {
                return GetItem(index);
            }
        }
    }
}
