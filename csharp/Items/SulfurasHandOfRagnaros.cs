namespace csharp.Items;

public class SulfurasHandOfRagnaros : BaseItem
{
    public override void UpdateItem(Item item)
    {
        if (QualityIsBelowMaximum(item.Quality))
        {
            item.Quality += 1;
        }
    }
}