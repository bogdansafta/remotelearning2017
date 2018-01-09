using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.Tests
{
    [TestClass]
    public class ContainableItemCollectionTests
    {
        ContainableItem containableItem = new ContainableItem()
        {
            Product = new Product
            {
                Name = "Cola",
                Price = 12.3,
                Category = new Category("Beverages"),
                Quantity = 3
            },
            Position = new Position(1, 1, 1, 3)
        };

        [TestMethod]
        public void AddItemTest()
        {
            ContainableItemCollection containableItemsCollection = new ContainableItemCollection();
           
            containableItemsCollection.Add(containableItem);

            Assert.AreEqual(containableItemsCollection.Count, 1);
            Assert.IsNotNull(containableItemsCollection[0]);
            Assert.IsTrue(containableItemsCollection.Contains(containableItem));
        }

        [TestMethod]
        public void RemoveItemTest()
        {
            ContainableItemCollection containableItemsCollection = new ContainableItemCollection();

            containableItemsCollection.Add(containableItem);
            containableItemsCollection.Remove(containableItem);

            Assert.AreNotEqual(containableItemsCollection.Count, 1);
            Assert.IsNull(containableItemsCollection.GetItem(0));
            Assert.IsFalse(containableItemsCollection.Contains(containableItem));
        }
    }
}
