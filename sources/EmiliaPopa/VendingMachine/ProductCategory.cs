using System;
namespace VendingMachine
{
  public  class ProductCategory : IEquatable<ProductCategory>
  {
      public string Name { get; set; }
      public ProductCategory()
      {

      }

      public ProductCategory( string name)
      {
          Name=name;
      }

       public bool Equals( ProductCategory other)
    {
        if (Name != other.Name)
        return false;
        return true;
    }

  }
}