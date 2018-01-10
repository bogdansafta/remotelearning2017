using System;

namespace VendingMachine
{
    public class ContainableItemCollection
    {
         public ContainableItem[] ContainableItems { get; set; }
         public int Size { get; set; }
         public int Capacity { get; set; } 
        
        public ContainableItemCollection()
        {
            ContainableItems = new ContainableItem[0];
            Size = 0;
            Capacity=0;
        }

        public ContainableItemCollection(int capacity)
        {
            ContainableItems = new ContainableItem[capacity];
        }

        public ContainableItem getItem(int i)
        {
            return ContainableItems[i];
        }

        public ContainableItem getItemById( int id)
        {int i;
            for( i=0;i<Size;i++)
            {
                if(ContainableItems[i].Position.ID==id)
                      break;
            }
            return ContainableItems[i];
        }

        public int count()
        {
            return Size;
        }

        public void remove(ContainableItem containableItem)
        { 
            ContainableItem[] newArray = new ContainableItem[Size];
            int j = 0;
            for (int i = 0; i < Size; i++)
                if (!containableItem.Equals(ContainableItems[i]))
                    newArray[j++] = ContainableItems[i];
            ContainableItems = new ContainableItem[j-1];
            ContainableItems = newArray; 
        }

        public void add(ContainableItem containableItem)
        {
            Size++;
            ContainableItem[] newArray = new ContainableItem[Size ];
            System.Array.Copy(ContainableItems, newArray, Size-1);
               if( Size-1!=-1)
                newArray[Size - 1] = containableItem;
            ContainableItems = new ContainableItem[Size];
            ContainableItems = newArray;
        }
     
       
    }

}
    
