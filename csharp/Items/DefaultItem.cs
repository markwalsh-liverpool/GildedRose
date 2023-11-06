namespace csharp.Items;

public class DefaultItem : BaseItem
{
    public override void UpdateItem(Item item)
    {
        if (QualityIsAboveMinimum(item.Quality))
        {
            item.Quality -= 1;
        }
        else if (QualityIsBelowMaximum(item.Quality))
        {
            item.Quality += 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && QualityIsAboveMinimum(item.Quality))
        {
            item.Quality -= 1;
        }
    }
}