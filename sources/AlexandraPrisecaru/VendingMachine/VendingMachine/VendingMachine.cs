namespace VendingMachine
{
    public class VendingMachine
    {
        private ContainableItemCollection items;

        private static VendingMachine instance;
        public static VendingMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VendingMachine();
                }
                return instance;
            }
        }

        public ContainableItemCollection Items { get => items ?? (items = GetHardcodedItems()); }

        private VendingMachine() { }

        private ContainableItemCollection GetHardcodedItems()
        {
            return new ContainableItemCollection(){
                new ContainableItem
                {
                    Product = new Product
                    {
                        Category = new Category("Beverages"),
                        Name = "Cola",
                        Price = 12.5,
                        Quantity=3
                    },
                    Position = new Position(row: 0, column: 1, id: 1)
                },
                new ContainableItem
                {
                    Product = new Product
                    {
                        Category = new Category("Snacks"),
                        Name = "Chips",
                        Price = 10.5,
                        Quantity=4
                    },
                    Position = new Position(row: 0, column: 2, id: 2, size: 2)
                },
                new ContainableItem
                {
                    Product = new Product
                    {
                        Category = new Category("Snacks"),
                        Name = "Popcorn",
                        Price = 8,
                        Quantity=3
                    },
                    Position = new Position(row: 0, column: 4, id: 4, size: 1)
                }
            };
        }
    }
}