namespace VendingMachine
{
    public class VendingMachine
    {
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

        public ContainableItemCollection Items { get; set; }

        private VendingMachine()
        {
            Items = new ContainableItemCollection();
        }
    }
}