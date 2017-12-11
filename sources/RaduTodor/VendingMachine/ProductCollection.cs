using System;

namespace VendingMachine
{
    internal class ProductCollection
    {
        int Size { get; set; }
        Node First;
        public Node GetFirst()=>First;

        public ProductCollection()
        {
            Size = 0;
            First = null;
        }

     
               public event EventHandler LocationOverlap;
             protected virtual void OnLocationOverlap(EventArgs e)
        {
            EventHandler handler = LocationOverlap;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public Node FindPrev(Product stranger,int x, int y,int z)
        {
            Node Temp = First;
            for (int i = 0; i < Size; i++)
                if (Temp.To != null && Temp.To.containableItem.product.Equals(stranger))
                    return Temp;
                else if (new Position(x,y,z).Equals(Temp.containableItem.position))
                {
                    OnLocationOverlap(EventArgs.Empty);
                }
                else
                    Temp = Temp.To;
            return null;
        }

        public void Add(Product New,int x,int y, int z)
        {
            Node Same = FindPrev(New,x,y,z);
            if (Same != null)
                Same.To.containableItem.product.SetQuantity(Same.To.containableItem.product.GetQuantity() + New.GetQuantity());
            else
            {
                Size++;
                Node Temp = new Node(New, First, x, y, z);
                First = Temp;
            }
        }
        public void Remove(Product stranger)
        {
            if (First.containableItem.product.Equals(stranger))
            {
                First = First.To;
                Size--;
            }
            else
            {

                Node Temp = FindPrev(stranger,-1,-1,-1);
                if (Temp != null)
                {
                    Temp.To = Temp.To.To;
                    Size--;
                }
            }
        }
        public int Count()
        {
            return Size;
        }
    }

}