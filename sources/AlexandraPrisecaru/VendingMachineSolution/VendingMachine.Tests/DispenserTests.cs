using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.Tests
{
    [TestClass]
    public class DispenserTests
    {
        [TestMethod]
        public void DispenseTest()
        {
            Dispenser dispenser = new Dispenser();

            VendingMachine vendingMachine = VendingMachine.Instance;
            ContainableItem containableItem = Helpers.ContainableItem;
            int initialQuantity = containableItem.Product.Quantity;
            vendingMachine.Items.Add(containableItem);

            Assert.ThrowsException<System.Exception>(() => dispenser.Dispense(23));
            Assert.IsNotNull(dispenser.Dispense(containableItem.Position.Id));
            Assert.AreNotEqual(initialQuantity, containableItem.Product.Quantity);

            containableItem.Product.Quantity=0;
            Assert.ThrowsException<System.Exception>(()=> dispenser.Dispense(containableItem.Position.Id));
            
            containableItem.Product.Quantity++;
            containableItem.Product=null;
            Assert.ThrowsException<System.Exception>(()=> dispenser.Dispense(containableItem.Position.Id));
        }
    }
}