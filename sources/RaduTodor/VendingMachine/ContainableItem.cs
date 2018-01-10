namespace VendingMachine
{
    class ContainableItem
    {
        public Product product;
        public Position position;

        public ContainableItem()
        {
            product = new Product();
            position = new Position();
        }
        public ContainableItem(Product prod, Position pos)
        {
            product = prod;
            position = pos;
        }
        public override string ToString()
        {
            return (product.ToString() + " " + position.ToString());
        }
        public bool Equals(ContainableItem other)
        {
            if (product.Equals(other.product))
                return true;
            else
                return false;
        }
        public bool EqualsPosition(ContainableItem other)
        {
            if (position.Equals(other.position))
                return true;
            else
                return false;
        }
    }
}