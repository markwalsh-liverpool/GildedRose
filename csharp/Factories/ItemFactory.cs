using csharp.Factories.Interfaces;
using csharp.Items;

namespace csharp.Factories;

public class ItemFactory : IItemFactory
{
    private const string ConjuredManaCake = "Conjured Mana Cake";
    private const string AgedBrie = "Aged Brie";
    private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
    private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

    public BaseItem CreateItem(string itemName)
    {
        switch (itemName)
        {
            case ConjuredManaCake:
                return new ConjuredManaCake();
            case AgedBrie:
                return new AgedBrie();
            case BackstagePasses:
                return new BackstagePasses();
            case SulfurasHandOfRagnaros:
                return new SulfurasHandOfRagnaros();
            default:
                return new DefaultItem();
        }
    }
}