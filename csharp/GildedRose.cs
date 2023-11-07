using System.Collections.Generic;
using csharp.Factories.Interfaces;

namespace csharp
{
    public class GildedRose
    {
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
