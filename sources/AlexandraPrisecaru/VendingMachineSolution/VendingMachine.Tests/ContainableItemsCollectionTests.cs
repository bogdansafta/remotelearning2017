using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.Tests
{
    [TestClass]
    public class ContainableItemCollectionTests
    {
        [TestMethod]
        public void AddItemTest()
        {
            ContainableItemCollection containableItemsCollection = new ContainableItemCollection();

            ContainableItem containableItem = Helpers.ContainableItem;
            containableItemsCollection.Add(containableItem);

            Assert.AreEqual(containableItemsCollection.Count, 1);
            Assert.IsNotNull(containableItemsCollection[0]);
            Assert.IsTrue(containableItemsCollection.Contains(containableItem));
        }

        [TestMethod]
        public void RemoveItemTest()
        {
            ContainableItemCollection containableItemsCollection = new ContainableItemCollection();
            ContainableItem containableItem = Helpers.ContainableItem;
            containableItemsCollection.Add(containableItem);
            containableItemsCollection.Remove(containableItem);

            Assert.IsNull(containableItemsCollection.GetItem(0));
            Assert.AreNotEqual(containableItemsCollection.Count, 1);
            Assert.IsFalse(containableItemsCollection.Contains(containableItem));
        }
    }
}
