using System;

namespace VendingMachine
{
    public class ContainableItem : IEquatable<ContainableItem>
    {
        public Position Position { get; set; } = new Position();

        public bool Equals(ContainableItem other)
        {
            //TODO CR @BS, have a look of what I wrote in Position.cs
            if (!Position.Equals(other.Position))
            {
                return false;
            }
            
            return true;
        }
    }
}