using System.Collections.Generic;
using System.Runtime.CompilerServices;
using csharp.Items;

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
                        var conjuredManaCake = new ConjuredManaCake();
                        conjuredManaCake.UpdateItem(item);
                        break;
                    }
                    case AgedBrie:
                    {
                        var agedBrie = new AgedBrie();
                        agedBrie.UpdateItem(item);
                        break;
                    }
                    case BackstagePasses:
                    {
                        var backstagePasses = new BackstagePasses();
                        backstagePasses.UpdateItem(item);
                        break;
                    }
                    case SulfurasHandOfRagnaros:
                    {
                        var sulfurasHandOfRagnaros = new SulfurasHandOfRagnaros();
                        sulfurasHandOfRagnaros.UpdateItem(item);
                        break;
                    }
                    default:
                    {
                        var defaultItem = new DefaultItem();
                        defaultItem.UpdateItem(item);
                        break;
                    }
                }
            }
        }
    }
}
