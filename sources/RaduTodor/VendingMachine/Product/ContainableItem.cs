namespace VendingMachine
{
    class ContainableItem
    {
        public Product Product;
        public Position Position;

        public ContainableItem()
        {
            Product = new Product();
            Position = new Position();
        }

        public ContainableItem(Product prod, Position pos)
        {
            Product = prod;
            Position = pos;
        }

        public override string ToString()
        {
            return (Product.ToString() + " " + Position.ToString());
        }

        public bool Equals(ContainableItem other)
        {
            if (Product.Equals(other.Product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EqualsPosition(ContainableItem other)
        {
            if (Position.Equals(other.Position))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}