using csharp.Items;
using csharp.Items.Base;
using csharp.Tests.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items;

[TestFixture]
public class BackstagePassesTests : BaseItemTest
{
    protected override BaseItem CreateBaseItem()
    {
        return new BackstagePasses();
    }

    [Test]
    public void UpdateItem_SellInGreaterThan10_QualityIncreasesByOne()
    {
        // Arrange
        var backstagePasses = new BackstagePasses { SellIn = 11, Quality = 20 };

        // Act
        backstagePasses.UpdateItem(backstagePasses);

        // Assert
        Assert.AreEqual(21, backstagePasses.Quality);
    }

    [Test]
    public void UpdateItem_SellInBetween6And10_QualityIncreasesByTwo()
    {
        // Arrange
        var backstagePasses = new BackstagePasses { SellIn = 8, Quality = 20 };

        // Act
        backstagePasses.UpdateItem(backstagePasses);

        // Assert
        Assert.AreEqual(22, backstagePasses.Quality);
    }

    [Test]
    public void UpdateItem_SellIsInBetween1And5_QualityIsIncreasedByThree()
    {
        // Arrange
        var backstagePasses = new BackstagePasses { SellIn = 3, Quality = 20 };

        // Act
        backstagePasses.UpdateItem(backstagePasses);

        // Assert
        Assert.AreEqual(23, backstagePasses.Quality);
    }

    [Test]
    public void UpdateItem_SellInIs0OrLess_QualityIsResetToZero()
    {
        // Arrange
        var backstagePasses = new BackstagePasses { SellIn = 0, Quality = 20 };

        // Act
        backstagePasses.UpdateItem(backstagePasses);

        // Assert
        Assert.AreEqual(0, backstagePasses.Quality);
    }
}