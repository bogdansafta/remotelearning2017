using System;

namespace VendingMachine
{
    internal class Node
    {
        public ContainableItem ContainableItem;
        public Node To;

        public Node()
        {
            ContainableItem = new ContainableItem();
            To = null;
        }

        public Node(ContainableItem newItem, Node nextNode)
        {
            ContainableItem=newItem;
            To = nextNode;
        }

        public Boolean HasSameID(int iD)
        {
            return ContainableItem.Position.HasSameID(iD);
        }

        public int GetQuantity()
        {
            return ContainableItem.Product.GetSize();
        }

        public void SetQuantity(int quantity)
        {
            ContainableItem.Product.SetSize(quantity);
        }
    }
}