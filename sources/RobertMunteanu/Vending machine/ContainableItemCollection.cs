using System;
namespace VendingMachine
{
    class ContainableItemCollection
    {
        private Product[] products = new Product[50];
        private int sizeIndex = 0;

        public void Add(Product product)
        {
            products[sizeIndex] = product;
            sizeIndex++;
        }

        public int SearchIndex(Product product)
        {
            int returnedValue = -1;
            for (int index = 0; index <= sizeIndex; index++)
            {
                if (products[index].Equals(product))
                {
                    return returnedValue;
                }
            }
            return returnedValue;
        }

        public void Remove(Product product)
        {
            if (SearchIndex(product) < 50 && SearchIndex(product) < sizeIndex)
            {
                for (int index = SearchIndex(product); index < sizeIndex; index++)
                {
                    products[index] = products[index + 1];
                }
                sizeIndex--;
            }
            if (SearchIndex(product) == sizeIndex)
            {
                products[SearchIndex(product)] = null;
                sizeIndex--;
            }
        }

        public int Count
        {
            get
            {
                return sizeIndex;
            }
        }

        public Product ItemByIndex(int index)
        {
            if (index > sizeIndex)
                return null;
            return products[index];
        }

        public void RemoveByPosition(Position position)
        {
            int positionToRemove = -1;
            for (int index = 0; index <= sizeIndex; index++)
            {
                if (products[index].position.Equals(position))
                    positionToRemove = index;
            }

            if (positionToRemove != -1)
            {
                for(int index = positionToRemove; index <sizeIndex ; index++)
                {
                    products[index] = products[index + 1];
                }
                sizeIndex--;
            }
        }
    }