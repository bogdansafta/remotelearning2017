using System;
using System.Collections;
using System.Collections.Generic;

namespace VendingMachine
{
    public class List<T> : ICollection<T>
    {
        private T[] internalItems;
        private int size;
        private int currentIndex = 0;

        public int Count
        {
            get
            {
                return currentIndex;
            }
        }

        public bool IsReadOnly { get; }

        public T this[int index]
        {
            get
            {
                if (index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return internalItems[index];
            }
        }

        public List()
        {
            size = 4;
            internalItems = new T[size];
        }

        public List(int size)
        {
            internalItems = new T[size];
            this.size = size;
        }

        public void Add(T item)
        {
            EnsureCapacity();
            internalItems[currentIndex] = item;
            currentIndex++;
        }

        public void AddRange(params T[] items)
        {
            EnsureCapacity(items.Length);

            foreach (T item in items)
            {
                internalItems[currentIndex] = item;
                currentIndex++;
            }
        }

        public void Clear()
        {
            if (Count > 0)
            {
                Array.Clear(internalItems, 0, Count);
                currentIndex = 0;
            }
        }

        public bool Contains(T item)
        {
            if(currentIndex==0){
                return false;
            }

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
            if (index > size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            Array.Copy(internalItems, index + 1, internalItems, index, size - index - 1);
            currentIndex--;
        }

        public T GetItem(int index)
        {
            if (index >= size || index < 0)
            {
                throw new IndexOutOfRangeException();
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

        private void EnsureCapacity(int capacity = 0)
        {
            if (capacity < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int length = currentIndex;

            if (capacity != 0)
            {
                length += capacity;
            }

            if (length >= size)
            {
                size = 4 * (Math.Abs(capacity / 4) + 1);

                T[] localItems = internalItems;
                internalItems = new T[size];
                Array.Copy(localItems, internalItems, localItems.Length);
            }
        }

        internal class Enumerator : IEnumerator<T>
        {
            private List<T> list;
            private int index;
            private T current;

            internal Enumerator(List<T> list)
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
                if (index < list.Count)
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