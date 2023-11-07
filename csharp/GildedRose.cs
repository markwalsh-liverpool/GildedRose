using System.Collections.Generic;
using csharp.Factories.Interfaces;

namespace csharp
{
    public class GildedRose
    {
        private const string ConjuredManaCake = "Conjured Mana Cake";
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

        private IList<Item> Items;
        private readonly IItemFactory ItemFactory;

        public GildedRose(IList<Item> items, IItemFactory itemFactory)
        {
            this.Items = items; 
            this.ItemFactory = itemFactory;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var baseItem = ItemFactory.CreateItem(item.Name);
                baseItem.UpdateItem(item);
            }
        }
    }
}
