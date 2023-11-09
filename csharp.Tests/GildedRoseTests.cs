using System.Collections.Generic;
using System.Linq;
using csharp.Factories;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityOf1AndSellInSetTo1_QualityIsZeroAndSellInIsZero()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 1, Quality = 1 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("foo", 0, 0, items.First());
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityOf1AndSellInSetTo0_QualityIsZeroAndSellInIMinus1()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 1} };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("foo", 0, -1, items.First());
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityOf2AndSellInSetToMinus1_QualityIsZeroAndSellInIsMinus2()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = -1, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("foo", 0, -2, items.First());
        }

        [Test]
        public void UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Aged Brie", 4, -1, items.First());
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Backstage passes to a TAFKAL80ETC concert", 4, 9, items.First());
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Backstage passes to a TAFKAL80ETC concert", 5, 4, items.First()); 
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetToMinus1_QualityIsZeroAndSellInIsMinusTwo()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Backstage passes to a TAFKAL80ETC concert", 0, -2, items.First());
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo12_QualityIsZeroAndSellInIsMinusTwo()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Backstage passes to a TAFKAL80ETC concert", 3, 11, items.First());
        }

        [Test]
        public void UpdateQuality_ForSulfurasHandOfRagnarosWithQualityOf80AndSellInSetToMinus1_QualityIsZeroAndSellInIsZero()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Sulfuras, Hand of Ragnaros", 80, 0, items.First());
        }

        [Test]
        public void UpdateQuality_ForConjuredManaCakeWithQualityOf6AndSellInSetTo3_QualityIsFourAndSellInIsTwo()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Conjured Mana Cake", 4, 2, items.First());
        }

        [Test]
        public void UpdateQuality_ForConjuredManaCakeWithQualityOf1AndSellInSetTo2_QualityIsZeroAndSellInIsOne()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "Conjured Mana Cake", SellIn = 2, Quality = 1 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            AssertExpectedItem("Conjured Mana Cake", 0 , 1, items.First());
        }

        private GildedRose CreateClassUnderTest(IList<Item> items)
        {
            return new GildedRose(items, new ItemFactory());
        }

        private void AssertExpectedItem(string name, int quality, int sellIn, Item item)
        {
            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(quality, item.Quality);
            Assert.AreEqual(sellIn, item.SellIn);
        }
    }
}
