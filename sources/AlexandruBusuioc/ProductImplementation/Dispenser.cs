using System;
namespace ProductImplementation
{
    public class Dispenser : IPaymentListener
    {
        private ContainableItemsCollection collection;
        public Dispenser(ContainableItemsCollection collection)
        {
            this.collection = collection;
            DataAcquisition.Instance.SetCollection(collection);
            
        }
        private ContainableItem VerifyCollection(int id)
        {
            if (collection.Count < 1)
            {
                throw new Exception("Collection is empty!");
            }
            ContainableItem toDispense = collection.FindByID(id);
            if (toDispense == null)
            {
                throw new NullReferenceException();
            }
            return toDispense;
        }
        private void Dispense(int id)
        {
            ContainableItem toDispense = VerifyCollection(id);
            toDispense.product.Quantity--;
        }
        
        public void Update(int id)
        {
            Dispense(id);
        }
        public Product GetProduct(int id)
        {
            ContainableItem toDispense = VerifyCollection(id);
            return toDispense.product;
        }
    }
}