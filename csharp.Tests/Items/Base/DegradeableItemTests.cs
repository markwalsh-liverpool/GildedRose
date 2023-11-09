using csharp.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items.Base
{
    public abstract class DegradeableItemTests<T> : BaseItemTest where T : BaseItem
    {
        [Test]
        public void UpdateItem_QualityIsDecreasedBelowTheMinimum_QualityDoesNotFallBelowTheMinimum()
        {
            // Arrange
            var baseItem = CreateBaseItem();
            baseItem.Quality = 0;
            baseItem.SellIn = 1;

            // Act
            baseItem.UpdateItem(baseItem);

            // Assert
            Assert.AreEqual(0, baseItem.Quality);
        }
    }
}
