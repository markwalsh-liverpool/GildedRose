using csharp.Items;
using csharp.Items.Base;
using csharp.Tests.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items;

[TestFixture]
public class DefaultItemTests : BaseItemTest
{
    protected override BaseItem CreateBaseItem()
    {
        return new DefaultItem();
    }

    [Test]
    public void UpdateItem_SellInIsGreaterThan0_QualityDecreasesByOne()
    {
        // Arrange
        var defaultItem = new DefaultItem { SellIn = 5, Quality = 10 };

        // Act
        defaultItem.UpdateItem(defaultItem);

        // Assert
        Assert.AreEqual(9, defaultItem.Quality);
    }

    [Test]
    public void UpdateItem_SellIn0OrLess_QualityDecreasesByTwo()
    {
        // Arrange
        var defaultItem = new DefaultItem { SellIn = 0, Quality = 10 };

        // Act
        defaultItem.UpdateItem(defaultItem);

        // Assert
        Assert.AreEqual(8, defaultItem.Quality);
    }
}