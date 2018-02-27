using System.Linq;
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
            int id = containableItem.Position.Id;
            vendingMachine.Items.Add(containableItem);
            ContainableItem vendingMachineItem = vendingMachine.Items.FirstOrDefault(item => item.Position.Id == id);

            Assert.ThrowsException<ProductNotFoundException>(() => dispenser.Dispense(23));
            Assert.IsNotNull(dispenser.Dispense(id));

            dispenser.Dispense(id);
            Assert.AreNotEqual(initialQuantity, vendingMachine.Items.FirstOrDefault(item => item.Position.Id == id).Product.Quantity);

            vendingMachineItem.Product.Quantity = 0;
            Assert.ThrowsException<ProductNotFoundException>(() => dispenser.Dispense(id));

            vendingMachineItem.Product.Quantity++;
            vendingMachineItem.Product = null;
            Assert.ThrowsException<ProductNotFoundException>(() => dispenser.Dispense(id));
        }
    }
}