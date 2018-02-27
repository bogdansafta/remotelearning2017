namespace VendingMachine
{
    public class ProductNotFoundException : System.Exception
    {
        public ProductNotFoundException(): base("Product requested not found."){ }
        public ProductNotFoundException(string productName) : base($"Product({productName}) not found.") { }
    }
}