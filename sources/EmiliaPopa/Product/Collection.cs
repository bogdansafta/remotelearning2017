namespace Product
{
    internal class Collection
    {
        
        public Products[] Products
        {
            get;
            set;
        }
        public int Size {
            get;
            set;
        }
        public Collection()
        {
            Products = new Products[0];
            Size = 0;
        }
        public Collection(int capacity)
        {
            Products = new Products[capacity];
          

        }
        public Products getItem(int i)
        {
            return Products[i];
        }

        public int count(Products product)
        { int c = 0;
            for (int i = 0; i < Size; i++)
                if (product.Equals(Products[i])) c++;   
            return c;

        }
        public void remove(Products product)
        { int s = Size - count(product);
            Products[] newArray = new Products[s];
            int j = 0;
            for (int i = 0; i < Size; i++)
                if (!product.Equals(Products[i]))
                    newArray[j++] = Products[i];
            Products = new Products[s];
            Products = newArray;
                    
            
        }
        public void add(Products product)
        {
            System.Type elementType = Products.GetType().GetElementType();
          //  Console.Write("elementType: {0} \n", elementType);
            Size++;
            Products[] newArray = new Products[Size ];
            System.Array.Copy(Products, newArray, Size-1);
               if( Size-1!=-1)
                newArray[Size - 1] = product;
            Products = new Products[Size];
            Products = newArray;
           
        }
     
       
    }
    }
