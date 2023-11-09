using csharp.Items;
using csharp.Items.Base;
using csharp.Tests.Items.Base;
using NUnit.Framework;

namespace csharp.Tests.Items;

[TestFixture]
public class ConjuredManaCakeTests : DegradeableItemTests<ConjuredManaCake>
{
    protected override BaseItem CreateBaseItem()
    {
        return new ConjuredManaCake();
    }

    [Test]
    public void UpdateItem_QualityIs2_QualityIsReducedByTwo()
    {
        // Arrange
        var backstagePasses = new ConjuredManaCake { SellIn = 0, Quality = 3 };

        // Act
        backstagePasses.UpdateItem(backstagePasses);

        // Assert
        Assert.AreEqual(1, backstagePasses.Quality);
    }
}