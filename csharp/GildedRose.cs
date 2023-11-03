using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            // UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        // UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    // UpdateQuality_ForUnknownItemWithQualitySetTo0_QualityIsZeroAndSellInIsMinus1
                    // UpdateQuality_ForUnknownItemWithQualityGreaterThan0_QualityIsZeroAndSellInIsMinus1
                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo10_QualityIsFourAndSellInIsNine
                    // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetTo5_QualityIsFiveAndSellInIsFour
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    // UpdateQuality_ForUnknownItemWithQualityGreaterThan1_QualityIsZeroAndSellInIsMinus1
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            // UpdateQuality_ForBackstagePassesToATAFKAL80ETCConcertWithQualityOf2AndSellInSetToMinus1_QualityIsZeroAndSellInIsMinusTwo
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            // UpdateQuality_ForAgedBrieWithQualityOf2AndSellInSetTo0_QualityIsFourAndSellInIsMinus1
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
