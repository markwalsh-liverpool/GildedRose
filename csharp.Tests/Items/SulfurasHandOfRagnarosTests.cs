using csharp.Items;
using NUnit.Framework;

namespace csharp.Tests.Items;

[TestFixture]
public class SulfurasHandOfRagnarosTests
{
    [TestCase(100)]
    [TestCase(-10)]
    [TestCase(100)]
    [TestCase(80)]
    public void UpdateItem_SellInIsGreaterThan0_QualityDecreasesByOne(int quality)
    {
        // Arrange
        var defaultItem = new SulfurasHandOfRagnaros() { Quality = quality };

        // Act
        defaultItem.UpdateItem(defaultItem);

        // Assert
        Assert.AreEqual(80, defaultItem.Quality);
    }
}