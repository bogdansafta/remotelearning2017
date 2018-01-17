using System;
namespace VendingMachine
{
    class ContainableItemCollection
    {
        private const int defaultMaxSize = 100;
        private ContainableItem[] products = new ContainableItem[defaultMaxSize];
        private int sizeIndex = 0;

        public ContainableItemCollection(ContainableItem[] products)
        {
            this.products = products;
            sizeIndex = products.Length;
        }

        public ContainableItemCollection(ContainableItem product)
        {
            Add(product);
        }

        public void Add(ContainableItem product)
        {
            products[sizeIndex] = product;
            sizeIndex++;
        }

        public int Count
        {
            get
            {
                return sizeIndex;
            }
        }

        public int SearchIndex(ContainableItem product)
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



        public ContainableItem ItemByIndex(int index)
        {
            if (index > sizeIndex)
            {
                return null;
            }
            return products[index];
        }

        public ContainableItem ItemByPosition(Position position)
        {
            int index = -1;
            for (int i = 0; i <= sizeIndex; i++)
            {
                if (products[i].Position.Equals(position))
                {
                    index = i;
                }
            }
            return products[index];
        }

        public ContainableItem ItemById(int id)
        {
            int index = -1;
            for (int i = 0; i <= sizeIndex; i++)
            {
                if (products[i].Position.Id == id)
                {
                    index = i;
                }
            }
            return products[index]
        }

        public void Remove(ContainableItem product)
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

        public void RemoveById(int Id)
        {
            ContainableItem itemToRemove = ItemById(Id);
            Remove(itemToRemove);
        }

        public void RemoveByPosition(Position position)
        {
            int positionToRemove = -1;
            for (int index = 0; index <= sizeIndex; index++)
            {
                if (products[index].Position.Equals(position))
                    positionToRemove = index;
            }

            if (positionToRemove != -1)
            {
                for (int index = positionToRemove; index < sizeIndex; index++)
                {
                    products[index] = products[index + 1];
                }
                sizeIndex--;
            }
        }
    }