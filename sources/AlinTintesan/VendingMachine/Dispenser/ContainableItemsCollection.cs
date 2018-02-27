using System;
using System.Data;

namespace VendingMachine
{
    public class ContainableItemsCollection
    {
        private ContainableItem[] items;

        private int size = 0;

        private int capacity = 4;

        public ContainableItemsCollection()
        {
            items = new ContainableItem[capacity];
        }

        public ContainableItemsCollection(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException("Capacity must be a positive number!");
            else
            {
                items = new ContainableItem[capacity];
                this.capacity = capacity;
            }
        }

        public ContainableItem Get(int index)
        {
            if (index < 0 || index >= this.size)
                throw new ArgumentOutOfRangeException("Index out of range!");
            else
                return this.items[index];
        }

        public ContainableItem GetByPosition(int position)
        {
            for(int index=0; index<this.size; index++)
                if(this.items[index].Position.Equals(position))
                    return this.items[index];
            return null;
        }

        public Product GetProductByID(int ID)
        {
            for(int index=0; index<this.size; index++)
            {
                ContainableItem itemToReturn=this.items[index];
                if(itemToReturn.Position.ID.Equals(ID) && itemToReturn.Product.Quantity>=1)
                    return itemToReturn.Product;
            }
            return null;
        }

        public int Count() => this.size;

        public void Add(ContainableItem containableItem)
        {
            if (this.capacity == this.size)
            {
                ContainableItem[] itemsCopy = this.items;
                this.items = new ContainableItem[2 * this.capacity];
                Array.Copy(itemsCopy, this.items, this.capacity);
                this.capacity *= 2;
            }
            this.items[this.size] = containableItem;
            this.size++;
        }

        public void Remove(ContainableItem containableItem)
        {
            int position = -1;
            for (int index = 0; index < this.size; index++)
                if (this.items[index].Equals(containableItem))
                {
                    position = index;
                    break;
                }
            if (position == -1)
            {
                Console.WriteLine("Object not found!");
                return;
            }
            else
            {
                Array.Copy(this.items, position + 1, this.items, position, this.size - position - 1);
                this.size--;
            }
        }
        
        public void ShowItems()
        {
            if (size == 0)
                Console.WriteLine("Collection empty!");
            else
                for (int index = 0; index < this.size; index++)
                    Console.WriteLine(this.items[index]);
        }
    }
}