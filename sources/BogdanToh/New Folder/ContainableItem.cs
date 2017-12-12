namespace New_Folder
{
    public class ContainableItem
    {
        public Position Position{get;set;}
        public ContainableItem(Position position)
        {
            this.Position=position;
        }
        public ContainableItem(){}
        public override string ToString()
        {
                     return $@"                          
                       Position:{this.Position}";
        }
    }
}
        