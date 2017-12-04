namespace VendingMachine
{
    internal class Node
    {
        public Product Product;
        public Node To;

        public Node()
        {
            Product = null;
            To = null;
        }
        public Node(Product product, Node node)
        {
            Product = product;
            To = node;
        }
    }
}