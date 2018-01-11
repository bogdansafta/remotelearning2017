using System;

namespace VendingMachine
{
    internal class ContainableItemsCollection
    {
        int Size { get; set; }
        Node First;
        public Node GetFirst() => First;

        public ContainableItemsCollection()
        {
            Size = 0;
            First = new Node();
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
        public Node FindPrevious(ContainableItem other)
        {
            Node Previous = First;
            for (int i = 0; i < Size; i++)
                if (Previous.To != null && Previous.To.containableItem.Equals(other))
                    return Previous;
                else if (Previous.containableItem.EqualsPosition(other))
                {
                    OnLocationOverlap(EventArgs.Empty);
                }
                else
                    Previous = Previous.To;
            return null;
        }

        public void Add(ContainableItem New)
        {
            Node Same = FindPrevious(New);
            if (Same != null)
                Same.To.SetQuantity(Same.To.GetQuantity() + New.product.GetSize());
            else
            {
                Size++;
                Node Temp = new Node(New, First);
                Temp.containableItem.position.ID1 = First.containableItem.position.ID1 + 1;
                First = Temp;
            }
        }
        public void Remove(ContainableItem Removing)
        {

            if (First.containableItem.position.Equals(Removing.position))
            {
                First = First.To;
                Size--;
            }
            else
            {

                Node Temp = First;
                for (int i = 1; i < Size; i++)
                {
                    if (Temp.To.containableItem.position.Equals(Removing.position))
                    {
                        Temp.To = Temp.To.To;
                        Size--;
                        break;
                    }
                    Temp = Temp.To;
                }
            }
        }
        public int Count()
        {
            return Size;
        }
        public ContainableItem GetByPoistion(Position pos)
        {
            if (First.containableItem.position.Equals(pos))
            {
                return First.containableItem;
            }
            else
            {

                Node Temp = First;
                for (int i = 1; i < Size; i++)
                {
                    if (Temp.To.containableItem.position.Equals(pos))
                    {
                        return Temp.To.containableItem;
                    }
                    Temp = Temp.To;
                }
            }
            return null;
        }
        public Boolean DecrementQuantity(int ID)
        {
            Node Actual = First;

            for (int i = 0; i < Size; i++)
            {
                if (Actual.HasSameID(ID))
                {
                    if (Actual.GetQuantity() > 0)
                    {
                        Actual.SetQuantity(Actual.GetQuantity() - 1);
                        return true;
                    }
                    else
                    {
                        throw new MyException("Product not in stock");
                    }
                }
                else
                    Actual = Actual.To;
            }
            return false;
        }
        public Product GetProductViaID(int ID)
        {
            Node Actual = First;

            for (int i = 0; i < Size; i++)
            {
                if (Actual.HasSameID(ID))
                {
                    return Actual.containableItem.product;
                }
                else
                    Actual=Actual.To;
            }
            return null;

        }
    }

}