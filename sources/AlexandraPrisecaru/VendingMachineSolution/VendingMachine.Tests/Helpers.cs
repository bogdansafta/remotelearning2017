namespace VendingMachine.Tests
{
    public class Helpers
    {
        public static ContainableItem ContainableItem
        {
            get
            {
                return new ContainableItem()
                {
                    Product = new Product
                    {
                        Name = "Cola",
                        Price = 12.3,
                        Category = new Category("Beverages"),
                        Quantity = 3
                    },
                    Position = new Position(1, 1, 1, 3)
                };
            }
        }
    }
}