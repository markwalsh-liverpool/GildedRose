namespace csharp.Items;

public class ConjuredManaCake : BaseItem
{
    public override void UpdateItem(Item item)
    {
        item.Quality -= 2;

        if (QualityIsBelowMinimum(item.Quality))
        {
            item.Quality = MinimumQuality;
        }

        item.SellIn -= 1;
    }
}