using System;
using System.Collections;
using System.Collections.Generic;

namespace VendingMachine
{
    public class MyList<T> : ICollection<T>
    {
        private T[] internalItems;
        private int size = 0;

        public MyList()
        {
            internalItems = new T[0];
            IsReadOnly = false;
        }

        public T this[int index]
        {
            get
            {
                if (index >= size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return internalItems[index];
            }
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            T[] items = internalItems;
            size++;
            internalItems = new T[size];
            Array.Copy(items, internalItems, size - 1);

            internalItems[size - 1] = item;
        }
        public void AddRange(params T[] items)
        {
            int length = items.Length;
            T[] localItems = internalItems;
            size += length;
            internalItems = new T[size];

            Array.Copy(localItems, internalItems, size - length);
            foreach (T item in items)
            {
                internalItems[size - length] = item;
                length--;
            }
        }

        public void Clear()
        {
            if (Count > 0)
            {
                Array.Clear(internalItems, 0, Count);
            }
        }

        public bool Contains(T item)
        {
            foreach (T elem in internalItems)
            {
                if (elem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(internalItems, 0, array, arrayIndex, size);
        }

        public bool Remove(T item)
        {
            for (int index = 0; index < size - 1; index++)
            {
                if (internalItems[index].Equals(item))
                {
                    RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= size)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (index < size)
                {
                    Array.Copy(internalItems, index + 1, internalItems, index, size - index - 1);
                    size--;
                }
            }
        }

        public T GetItem(int index){
            if(index>=size){
                throw new ArgumentOutOfRangeException();
            }
            return this[index];
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
            private MyList<T> list;
            private int index;
            private T current;

            internal Enumerator(MyList<T> list)
            {
                this.list = list;
                index = 0;
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
                if (index < list.size)
                {
                    current = list.internalItems[index];
                    index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                index = 0;
                current = default(T);
            }
        }
    }
}