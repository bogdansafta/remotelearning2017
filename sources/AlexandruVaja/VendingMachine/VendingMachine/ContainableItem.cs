using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class ContainableItem : IEquatable<ContainableItem>
    {
        public Position productPosition = new Position();

        public bool Equals(ContainableItem other)
        {
            if (Equals(other.productPosition)) //!Position.Equals(other.productPosition)
                return false;
            return true;
        }
    }
}
