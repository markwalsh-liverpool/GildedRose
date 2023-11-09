using csharp.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items.Base
{
    public abstract class UpgradeableItemTests<T> : BaseItemTest where T : BaseItem
    {
        [Test]
        public void UpdateItem_QualityIsIncreasedBeyondTheMaximum_QualityDoesNotExceedTheMaximum()
        {
            // Arrange
            var baseItem = CreateBaseItem();
            baseItem.Quality = 50;
            baseItem.SellIn = 5;

            // Act
            baseItem.UpdateItem(baseItem);

            // Assert
            Assert.AreEqual(50, baseItem.Quality);
        }
    }
}
