using System.Collections.Generic;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void UpdateQuality_ForUnknownItemWithQualitySetTo0_QualityIsZeroAndSellInIsMinus1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForUnknownItemWithQualityGreaterThan1_QualityIsZeroAndSellInIsMinus1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(4, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(4, Items[0].Quality);
            Assert.AreEqual(9, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(5, Items[0].Quality);
            Assert.AreEqual(4, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetToMinus1_QualityIsZeroAndSellInIsMinusTwo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-2, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo12_QualityIsZeroAndSellInIsMinusTwo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(3, Items[0].Quality);
            Assert.AreEqual(11, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForSulfurasHandOfRagnarosWithQualityOf80AndSellInSetToMinus1_QualityIsZeroAndSellInIsZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(0, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForConjuredManaCakeWithQualityOf6AndSellInSetTo3_QualityIsFourAndSellInIsTwo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
            Assert.AreEqual(4, Items[0].Quality);
            Assert.AreEqual(2, Items[0].SellIn);
        }

        [Test]
        public void UpdateQuality_ForConjuredManaCakeWithQualityOf1AndSellInSetTo2_QualityIsZeroAndSellInIsOne()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(1, Items[0].SellIn);
        }
    }
}
