namespace csharp.Items;

public class DefaultItem : BaseItem
{
    protected override int MaximumQuality => 50;

    public override void UpdateItem(Item item)
    {
        if (QualityIsAboveMinimum(item.Quality))
        {
            item.Quality -= 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && QualityIsAboveMinimum(item.Quality))
        {
            item.Quality -= 1;
        }
    }
}