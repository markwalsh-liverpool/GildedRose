using csharp.Items;
using csharp.Items.Base;
using csharp.Tests.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items;

[TestFixture]
public class AgedBrieTests : BaseItemTest
{
    protected override BaseItem CreateBaseItem()
    {
        return new AgedBrie();
    }

    [Test]
    public void UpdateItem_QualityIncreasesBy1WhenSellInIsMoreThan0_QualityIsIncreasedByOne()
    {
        // Arrange
        var agedBrie = new AgedBrie { Name = "Aged Brie", Quality = 10, SellIn = 5 };

        // Act
        agedBrie.UpdateItem(agedBrie);

        // Assert
        Assert.AreEqual(11, agedBrie.Quality);
    }

    [TestCase(-1)]
    [TestCase(0)]
    public void UpdateItem_QualityIncreasesBy2WhenSellInIsLessThanOrEqualTo0_QualityIsIncreasedByTwo(int sellIn)
    {
        // Arrange
        var agedBrie = new AgedBrie { Name = "Aged Brie", Quality = 10, SellIn = sellIn };

        // Act
        agedBrie.UpdateItem(agedBrie);

        // Assert
        Assert.AreEqual(12, agedBrie.Quality);
    }
}