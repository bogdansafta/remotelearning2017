namespace VendingMachine
{
    class ContainableItem
    {
        public Product product;
        public Position position;

        public ContainableItem()
        {
            product = null;
            position = new Position();
        }
        public ContainableItem(Product prod, Position pos)
        {
            product = prod;
            position = pos;
        }
        public override string ToString()
        {
            return (product.Gettype() + " " + product.GetName() + " " + product.GetQuantity() + " " + position.ToString());
        }
    }
}