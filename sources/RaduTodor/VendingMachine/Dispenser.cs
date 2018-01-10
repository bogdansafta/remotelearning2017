using System;

namespace VendingMachine
{
    internal class Dispenser
    {
        private ContainableItemsCollection Collection;

        public Dispenser(ContainableItemsCollection collection)
        {
            Collection = collection;
        }

        public event EventHandler LocationNotAvailable;
        protected virtual void OnLocationNotAvailable(EventArgs e)
        {
            EventHandler handler = LocationNotAvailable;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler NotInStock;
        protected virtual void OnNotInStock(EventArgs e)
        {
            EventHandler handler = NotInStock;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public Product Dispense(int ID)
        {
            
            Node Actual = Collection.GetFirst();

            for (int i = 0; i < Collection.Count(); i++)
            {
                if (Actual.containableItem.position.SameID(ID))
                {
                    if (Actual.containableItem.product.GetSize() > 0)
                    {
                        Actual.containableItem.product.SetSize(Actual.containableItem.product.GetSize() - 1);
                        return Actual.containableItem.product;
                    }
                    else
                    {
                        OnNotInStock(EventArgs.Empty);
                        return null;
                    }
                }
                else
                    Actual = Actual.To;
            }
            OnLocationNotAvailable(EventArgs.Empty);
            return null;
        }
    }
}