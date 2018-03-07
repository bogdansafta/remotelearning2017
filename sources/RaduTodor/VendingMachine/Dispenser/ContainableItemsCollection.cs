using System;

namespace VendingMachine
{
    internal class ContainableItemsCollection
    {
        int Size { get; set; }

        Node first;

        public Node GetFirst() => first;

        public ContainableItemsCollection()
        {
            Size = 0;
            first = new Node();
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
            Node previous = first;
            for (int i = 0; i < Size; i++)
            {
                if (previous.To != null && previous.To.ContainableItem.Equals(other))
                {
                    return previous;
                }
                else if (previous.ContainableItem.EqualsPosition(other))
                {
                    OnLocationOverlap(EventArgs.Empty);
                }
                else
                {
                    previous = previous.To;
                }
            }
            return null;
        }

        public void Add(ContainableItem @new)
        {
            Node same = FindPrevious(@new);
            if (same != null)
            {
                same.To.SetQuantity(same.To.GetQuantity() + @new.Product.GetSize());
            }
            else
            {
                Size++;
                Node temp = new Node(@new, first);
                temp.ContainableItem.Position.ID1 = first.ContainableItem.Position.ID1 + 1;
                first = temp;
            }
        }

        public void Remove(ContainableItem removing)
        {
            if (first.ContainableItem.Position.Equals(removing.Position))
            {
                first = first.To;
                Size--;
            }
            else
            {
                Node temp = first;
                for (int i = 1; i < Size; i++)
                {
                    if (temp.To.ContainableItem.Position.Equals(removing.Position))
                    {
                        temp.To = temp.To.To;
                        Size--;
                        break;
                    }
                    temp = temp.To;
                }
            }
        }

        public int Count()
        {
            return Size;
        }

        public ContainableItem GetByPoistion(Position pos)
        {
            if (first.ContainableItem.Position.Equals(pos))
            {
                return first.ContainableItem;
            }
            else
            {
                Node temp = first;
                for (int i = 1; i < Size; i++)
                {
                    if (temp.To.ContainableItem.Position.Equals(pos))
                    {
                        return temp.To.ContainableItem;
                    }
                    temp = temp.To;
                }
            }
            return null;
        }

        public Boolean DecrementQuantity(int iD)
        {
            Node actual = first;
            for (int i = 0; i < Size; i++)
            {
                if (actual.HasSameID(iD))
                {
                    if (actual.GetQuantity() > 0)
                    {
                        actual.SetQuantity(actual.GetQuantity() - 1);
                        return true;
                    }
                    else
                    {
                        throw new MyException("Product not in stock");
                    }
                }
                else
                {
                    actual = actual.To;
                }
            }
            return false;
        }

        public Product GetProductViaID(int iD)
        {
            Node actual = first;
            for (int i = 0; i < Size; i++)
            {
                if (actual.HasSameID(iD))
                {
                    return actual.ContainableItem.Product;
                }
                else
                {
                    actual = actual.To;
                }
            }
            return null;
        }
    }
}