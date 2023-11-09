using NUnit.Framework;
using csharp.Items.Base;

namespace csharp.Tests.Items.Base
{
    public abstract class BaseItemTest
    {
        protected abstract BaseItem CreateBaseItem();

        [Test]
        public void UpdateItem_ForAllItems_SellInIsDecreasedByOne()
        {
            // Arrange
            var baseItem = CreateBaseItem();
            baseItem.Quality = 10;
            baseItem.SellIn = 5;

            // Act
            baseItem.UpdateItem(baseItem);

            // Assert
            Assert.AreEqual(4, baseItem.SellIn);
        }
    }
}
