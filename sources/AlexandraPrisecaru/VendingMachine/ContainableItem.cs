using System;

namespace VendingMachine
{
    public class ContainableItem : IEquatable<ContainableItem>
    {
        public Position Position { get; set; } = new Position();
        public int Size { get; set; } = 1;

        public bool Equals(ContainableItem other)
        {
            if (!Position.Equals(other.Position))
            {
                return false;
            }
            if (!Size.Equals(other.Size))
            {
                return false;
            }

            return true;
        }
    }
}