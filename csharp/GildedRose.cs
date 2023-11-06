using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private const string ConjuredManaCake = "Conjured Mana Cake";
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name == ConjuredManaCake)
                {
                    if (item.Quality - 2 >= 0)
                    {
                        item.Quality -= 2;
                    }
                    else
                    {
                        item.Quality = 0;
                    }

                    item.SellIn -= 1;
                    break;
                }

                if (item.Name != AgedBrie && item.Name != BackstagePasses && item.Name != SulfurasHandOfRagnaros)
                {
                    if (item.Quality > 0)
                    {
                            // UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1
                            item.Quality -= 1;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        // UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1
                        item.Quality += 1;

                        if (item.Name == BackstagePasses)
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                                    item.Quality += 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                                    item.Quality += 1;
                                }
                            }
                        }
                    }
                }

                if (item.Name != SulfurasHandOfRagnaros)
                {
                    // UpdateQuality_ForUnknownItemWithQualitySetTo0_QualityIsZeroAndSellInIsMinus1
                    // UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1
                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine
                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                    item.SellIn -= 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != AgedBrie)
                    {
                        if (item.Name != BackstagePasses)
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != SulfurasHandOfRagnaros)
                                {
                                    // UpdateQuality_ForUnknownItemWithQualityGreaterThan1_QualityIsZeroAndSellInIsMinus1
                                    item.Quality -= 1;
                                }
                            }
                        }
                        else
                        {
                            // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetToMinus1_QualityIsZeroAndSellInIsMinusTwo
                            item.Quality -= item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            // UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1
                            item.Quality += 1;
                        }
                    }
                }
            }
        }
    }
}
