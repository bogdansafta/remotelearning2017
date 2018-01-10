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
    }
}