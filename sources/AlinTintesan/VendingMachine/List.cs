using System;
using System.Collections;
using System.Collections.Generic;

namespace VendingMachine
{
    public class List<Type>
    {
        private Node<Type> head;
        private Node<Type> last;
        private int numberOfObjects;

        public List()
        {
            head=null;
            last=null;
            numberOfObjects=0;
        }
        public void Add(Type newObject)
        {
            if(head==null)
            {
                head=new Node<Type>();
                head.data=newObject;
                last=head;
                numberOfObjects++;
            }
            else
            {
                Node<Type> newNode=new Node<Type>();
                newNode.data=newObject;
                last.next=newNode;
                last=newNode;
                numberOfObjects++;
            }
        }

        public void Remove(Type objectToRemove)
        {
            if(head==null)
                return;
            if(head.data.Equals(objectToRemove))
            {
                head=head.next;
                numberOfObjects--;
                return;
            }
            Node<Type> objectToFind=head;
            while(objectToFind.next!=null && !(objectToFind.next.data.Equals(objectToRemove)))
                objectToFind=objectToFind.next;
            objectToFind.next=objectToFind.next.next;
            numberOfObjects--;
        }

        public int Count()
        {
            return numberOfObjects;
        }

        public Type GetItem(int index)
        {
            Node<Type> objectToFind=head;
            if(index>=0 && index<numberOfObjects)
                for(int listIterator=0;listIterator<index;listIterator++)
                    objectToFind=objectToFind.next;
            return objectToFind.data;
        }

    
    }
}