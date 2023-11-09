using csharp.Factories.Interfaces;
using csharp.Items;
using csharp.Items.Base;

namespace csharp.Factories;

public class ItemFactory : IItemFactory
{
    public BaseItem CreateItem(string itemName)
    {
        return itemName switch
        {
            not null when itemName.StartsWith("Conjured") => new ConjuredManaCake(),
            "Aged Brie" => new AgedBrie(),
            not null when itemName.StartsWith("Backstage") => new BackstagePasses(),
            not null when itemName.StartsWith("Sulfuras") => new SulfurasHandOfRagnaros(),
            _ => new DefaultItem()
        };
    }
}