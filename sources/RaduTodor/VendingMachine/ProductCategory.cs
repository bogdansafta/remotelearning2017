namespace VendingMachine
{
    internal class ProductCategory
    {
        string Name;
        public ProductCategory()
        {
            Name = null;
        }
        public ProductCategory(string x)
        {
            Name = x;
        }

        public string Name1 { get => Name; set => Name = value; }
    }
}