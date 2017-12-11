namespace VendingMachine
{
    internal class Node
    {
        public ContainableItem containableItem;
        public Node To;

        public Node()
        {
            containableItem = null;
            To = null;
        }
        public Node(Product product,Node node,int x, int y, int z)
        {
            containableItem=new ContainableItem(product,new Position(x,y,z));
            To = node;
        }
    }
}