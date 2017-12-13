using System;
using System.Collections;
namespace ProductImplementation
{
    public class ProductCategory
    {
        public string name;

        public ProductCategory(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}