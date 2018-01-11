using System;

namespace VendingMachine
{
    internal class Node
    {
        public ContainableItem containableItem;
        public Node To;

        public Node()
        {
            containableItem = new ContainableItem();
            To = null;
        }
        public Node(ContainableItem NewItem,Node NextNode)
        {
            containableItem=NewItem;
            To = NextNode;
        }
        public Boolean HasSameID(int ID)
        {
            return containableItem.position.HasSameID(ID);
        }
        public int GetQuantity()
        {
            return containableItem.product.GetSize();
        }
        public void SetQuantity(int Quantity)
        {
            containableItem.product.SetSize(Quantity);
        }
    }
}