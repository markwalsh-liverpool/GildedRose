namespace csharp.Items;

public class AgedBrie : BaseItem
{
    protected override int MaximumQuality => 50;

    public override void UpdateItem(Item item)
    {
        if (QualityIsBelowMaximum(item.Quality))
        {
            item.Quality += 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && QualityIsBelowMaximum(item.Quality))
        {
            item.Quality += 1;
        }
    }
}