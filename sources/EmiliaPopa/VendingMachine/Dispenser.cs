using System;

namespace VendingMachine
{
    public class Dispenser
    {
        public ContainableItemCollection ContainableItemCollection{ get; set;}

        public Dispenser(ContainableItemCollection containableItemCollection)
        {
            ContainableItemCollection=containableItemCollection;
        }
              public Product dispense( int id)
              {
                  return ContainableItemCollection.getItemById(id).Product;
              }
      
    }
    
}