﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VendingMachine
{
    class ProductList<T> : ICollection
    {
        object[] elementData;
        object[] INITIAL_DATA = { };
        int INITIAL_CAPACITY = 0;
        int size;

        int ICollection.Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public ProductList()
        {
            this.elementData = INITIAL_DATA;
        }

        public ProductList(int initialCapacity)
        {
            if (initialCapacity < 0)
                throw new ArgumentOutOfRangeException("Capacitate initiala negativa!");
            elementData = new object[initialCapacity];
        }

        public ProductList(ICollection collection)
        {
            if (collection == null)
                throw new ArgumentNullException("Nu exista nici un element in colectie!");
            size = collection.Count;
            elementData = new object[collection.Count];
            collection.CopyTo(elementData, 0);
        }

        public void Add(T newObject)
        {
            object[] copyData = elementData;
            ++size;
            elementData = new object[size];
            for (int i = 0; i < copyData.Length; i++)
                elementData[i] = copyData[i];
            elementData[size - 1] = newObject;
        }

        public void AddRange(ICollection collection)
        {
            if (collection == null)
                throw new ArgumentNullException("Nu exista nici un element in colectie!");
            EnsureCapacity(size + collection.Count);
            collection.CopyTo(elementData, 0);

        }
        private void EnsureCapacity(int minimCapacity)
        {
            int newCapacity = -1;
            if (elementData.Length < minimCapacity)
            {
                if (elementData.Length == 0)
                    newCapacity = INITIAL_CAPACITY;
                else
                    newCapacity = elementData.Length * 2;
            }
            if (newCapacity < minimCapacity)
                newCapacity = minimCapacity;
            size = newCapacity;
        }

        public void Remove(T element)
        {
            object[] copyData = new object[size - 1];
            Boolean ok = true;
            for (int i = 0; i < elementData.Length - 1; i++)
            {
                if (!elementData[i].Equals(element) && ok)
                {
                    copyData[i] = elementData[i];
                }
                else ok = false;
                if (!ok)
                    copyData[i] = elementData[i + 1];
            }
            elementData = new object[copyData.Length];
            elementData = copyData;
            size--;
        }
        public int Count()
        {
            return this.size;
        }

        public object GetItem(int x)
        {
            return elementData[x];
        }

        public void CopyTo(Array array, int index)
        {
            Array.Copy(array, 0, elementData, index, size);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}