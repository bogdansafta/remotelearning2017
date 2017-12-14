using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class ProductCategory
    {
        public string Name { get; set; }

        public ProductCategory()
        {
            Name = null;
        }

        public override string ToString() => $"Name = {Name}";

    }
}
