namespace VendingMachine
{
    public class ContainableItem
    {
        public Position Position{get;private set;}
        public Product Product{get; private set;}
        public ContainableItem(Product product,Position position)
        {
            
            this.Product = product;
            this.Position = position;
        }
        public ContainableItem(){}
        public override string ToString()
        {
                     return $@"
                       Product:  {this.Product}                          
                       Position: {this.Position}";
        }
    }
}
        