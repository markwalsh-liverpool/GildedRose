using System.Collections.Generic;
using csharp.Factories;
using csharp.Factories

Framework.Interfaces;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void UpdateQuality_ForUnknownItemWithQualitySetTo0_QualityIsZeroAndSellInIsMinus1()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual("foo", items[0].Name);
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 1 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual("foo", items[0].Name);
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityGreaterThan1_QualityIsZeroAndSellInIsMinus1()
        {
            // Arrange
            IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 2 } };
            var app = CreateClassUnderTest(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual("foo", items[0].Name);
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
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
            Assert.AreEqual("Aged Brie", items[0].Name);
            Assert.AreEqual(4, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
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
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.AreEqual(4, items[0].Quality);
            Assert.AreEqual(9, items[0].SellIn);
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
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.AreEqual(5, items[0].Quality);
            Assert.AreEqual(4, items[0].SellIn);
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
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-2, items[0].SellIn);
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
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.AreEqual(3, items[0].Quality);
            Assert.AreEqual(11, items[0].SellIn);
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
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", items[0].Name);
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
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
            Assert.AreEqual("Conjured Mana Cake", items[0].Name);
            Assert.AreEqual(4, items[0].Quality);
            Assert.AreEqual(2, items[0].SellIn);
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
            Assert.AreEqual("Conjured Mana Cake", items[0].Name);
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(1, items[0].SellIn);
        }

        private GildedRose CreateClassUnderTest(IList<Item> items)
        {
            return new GildedRose(items, new ItemFactory());
        }
    }
}
