namespace VendingMachine
{
    public class ProductNotFoundException : System.Exception
    {
        public ProductNotFoundException() : base("Product requested not found.") { }
        public ProductNotFoundException(int id) : base($"Product at id={id} not found.") { }
    }
}