namespace VendingMachine
{
    internal class ProductCategory
    {
        string name;
        public ProductCategory()
        {
            name = null;
        }

        public ProductCategory(string x)
        {
            name = x;
        }

        public string Name { get => name; set => name = value; }
    }
}