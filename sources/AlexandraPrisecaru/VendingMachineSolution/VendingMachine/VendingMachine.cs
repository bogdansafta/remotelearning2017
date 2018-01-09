namespace VendingMachine
{
    public class VendingMachine
    {
        public static VendingMachine Instance
        {
            get
            {
                return new VendingMachine();
            }
        }

        public ContainableItemCollection Items { get; set; }

        private VendingMachine()
        {
            Items = new ContainableItemCollection();
        }
    }
}