using System;
using System.Linq;

namespace VendingMachine
{
    public class ContainableItemCollection : List<ContainableItem>
    {
        public bool RemoveBy(Position position)
        {
            ContainableItem containableItem = this.FirstOrDefault(item => item.Position.Equals(position));
            if (containableItem == null)
            {
                return false;
            }

            this.Remove(containableItem);
            return true;
        }

        public Product GetProductById(int id){
            ContainableItem item = this.FirstOrDefault(containableItem => containableItem.Position.Id == id);

            if (item == null)
            {
                throw new System.Exception("Invalid id.");
            }

            if (item.Product == null || item.Product.Quantity < 1)
            {
                throw new System.Exception("No product found at this id.");
            }
            
            return item.Product;

        }
    }
}