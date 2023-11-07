namespace csharp.Items;

public class BackstagePasses : BaseItem
{
    protected override int MaximumQuality => 50;

    public override void UpdateItem(Item item)
    {
        switch (item.SellIn)
        {
            case <= 5:
                item.Quality += 3;
                break;
            case <= 10:
                item.Quality += 2;
                break;
            default:
                item.Quality += 1;
                break;
        }
            
        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            item.Quality -= item.Quality;
        }

        if (QualityIsAboveMaximum(item.Quality))
        {
            item.Quality = MaximumQuality;
        }
    }
}