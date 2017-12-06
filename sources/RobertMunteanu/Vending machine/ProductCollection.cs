using System;

namespace VendingMachine
{
    class ProductCollection 
    {
         private ProductStack first = null;
        private ProductStack last = null;
        private int productCount = 0;
        private int freeCells;

        public int CountProducts()
        {
            return productCount;
        }

        public ProductCollection(int freeCells)
        {
            this.freeCells = freeCells;
        }

        public void AddProduct(Product product)
        {
            if (first == null)
            {
                first.ThisProduct = product;
                first.NextProduct = last;
                last.ThisProduct = product;
                freeCells -= product.NumberOfCells;
                productCount = 1;
            }
            else
            {
                if (product.NumberOfCells > freeCells)
                {
                    Console.WriteLine("there are not enough cells available to make " + product.Name + " product addition");
                }
                else
                {
                    last.NextProduct = new ProductStack(product);
                    productCount++;
                    freeCells -= product.NumberOfCells;
                    Console.WriteLine("product " + product.Name + " successfully added");
                }
            }
        }

        public Product GetProduct(string name)
        {
            if (first == null)
            {
                Console.WriteLine("product not found");
                return null;
            }
            if (first.ThisProduct.Name.Equals(name))
            {
                return first.ThisProduct;
            }
            else
            {
                ProductStack searchProduct = first.NextProduct;
                while (!searchProduct.ThisProduct.Equals(null))
                {
                    if (searchProduct.ThisProduct.Name.Equals(name))
                    {
                        return searchProduct.ThisProduct;
                    }
                    else
                    {
                        searchProduct = searchProduct.NextProduct;
                    }
                }
            }

            Console.WriteLine("poduct not found");
            return null;
        }

        public void RemoveProduct(string name)
        {
            if (GetProduct(name).Equals(null))
                return;
            else
            {
                ProductStack productToRemove = new ProductStack(GetProduct(name));
                productToRemove = productToRemove.NextProduct;
                Console.WriteLine("product " + name + " successfully removed");
                freeCells += productToRemove.ThisProduct.NumberOfCells;
                productCount--;
            }
        }
    }
}