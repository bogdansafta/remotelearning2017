using System;
namespace VendingMachine
{
    public class Product: IEquatable<Product>{

    public ProductCategory Category { get; set; }
    public float Price { get; set; }
    public int Size { get; set; }
    public string Name { get; set; }

    public Product()
    {
        
    }
    public Product(ProductCategory category, float price, int size, string name){
        Category=category;
        Price=price;
        Size=size;
        Name=name;

    }

     public bool Equals( Product other)
    {
        if (Category!=other.Category ||Price!=other.Price||Size!=other.Size || Name!=other.Name)
        return false;
        return true;
    }


    }
}