using System;
using System.Linq;

namespace VendingMachine
{
    public class ContainableItemCollection : Collection<ContainableItem>
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

        public Product GetProductById(int id)
        {
            ContainableItem item = this.FirstOrDefault(containableItem => containableItem.Position.Id == id);

            if (item?.Product == null || item.Product.Quantity == 0)
            {
                throw new ProductNotFoundException();
            }

            return item.Product;

        }
    }
}