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
        public void RemoveByPosition(Position position)
        {
            Node element = head;
            if (count <= -1)
                throw new NullReferenceException();
            if (element.item.position.Equals(position))
            {
                ContainableItem toDelete = element.item;
                Remove(toDelete);
                return;
            }
            while (element.next != null)
            {
                if (element.item.position.Equals(position))
                {
                    ContainableItem toDelete = element.item;
                    Remove(toDelete);
                }
                else
                {
                    element = element.next;
                }
            }
            if (element == current && element.item.position.Equals(position))
            {
                ContainableItem toDelete = element.item;
                Remove(toDelete);
            }
            else if (element == current && !element.item.position.Equals(position))
                throw new Exception("Element not found!");

        }
        public ContainableItem FindByID(int id)
        {
            Node element = head;
            if (count <= -1)
                throw new NullReferenceException();
            if (element.item.position.id.Equals(id))
            {
                return element.item;
            }
            while (element.next != null)
            {
                if (element.item.position.id.Equals(id))
                {
                    return element.item;
                }
                else
                {
                    element = element.next;
                }
            }
            if (element == current && element.item.position.id.Equals(id))
            {
                return element.item;
            }
            else if (element == current && !element.item.position.id.Equals(id))
            {
                throw new Exception("Element not found!");
            }
            return null;
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

            if (removed.Equals(current.item))
            {
                current = temp;
                current.next = null;
                count--;
                return;
            }
        }

        public ContainableItem this[int index]
        {
            get
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
        }
    }
}
