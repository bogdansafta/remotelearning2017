using System;

namespace VendingMachine
{
    public class ContainableItem //: IEquatable<ContainableItem>
    {
        public Position Position;

        public ContainableItem(Position position)
        {
            this.Position = position;
        }
        

        /* public bool Equals(ContainableItem other)
        {
            return this.Position.Equals(other);
        } */

        /* public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ContainableItem containableItem = obj as ContainableItem;
            if (containableItem == null)
                return false;
            else
                return this.Equals(containableItem);

        } */

        public override string ToString() => $"Position: {this.Position} \n";
    }
}