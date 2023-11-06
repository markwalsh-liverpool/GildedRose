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
                switch (item.Name)
                {
                    case ConjuredManaCake:
                    {
                        item.Quality -= 2;
                       
                        if (item.Quality < 0) {

                            item.Quality = 0;
                        }

                        item.SellIn -= 1;
                        break;
                    }
                    case AgedBrie:
                    {
                        if (QualityIsUnder50(item))
                        {
                            item.Quality += 1;
                        }

                        item.SellIn -= 1;

                        if (item.SellIn < 0 && item.Quality < 50)
                        {
                            item.Quality += 1;

                        }

                        break;
                    }
                    case BackstagePasses:
                    {
                        if (QualityIsUnder50(item))
                        {
                            item.Quality += 1;
                        }

                        if (item.SellIn < 11 && QualityIsUnder50(item))
                        {
                            item.Quality += 1;
                        }

                        if (item.SellIn < 6 && QualityIsUnder50(item))
                        {
                            item.Quality += 1;
                        }

                        item.SellIn -= 1;


                        if (item.SellIn < 0)
                        {
                            item.Quality -= item.Quality;
                        }


                        break;
                }
                    case SulfurasHandOfRagnaros:
                    {
                        if (QualityIsUnder50(item))
                        {
                            item.Quality += 1;
                        }

                        break;
                    }
                    default:
                    {
                        if (item.Quality > 0)
                        {
                            item.Quality -= 1;
                        }
                        else if (item.Quality < 50)
                        {
                            item.Quality += 1;
                        }

                        item.SellIn -= 1;

                        if (item.SellIn < 0 && item.Quality > 0)
                        {
                            item.Quality -= 1;
                        }
                        break;
                    }
                }
            }
        }

        private static bool QualityIsUnder50(Item item)
        {
            return item.Quality < 50;
        }
    }
}
