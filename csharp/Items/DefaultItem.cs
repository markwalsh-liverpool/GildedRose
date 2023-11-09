using csharp.Items.Base;

namespace csharp.Items;

public class DefaultItem : VariableQualityBaseItem
{
    protected override void AdjustQuality(Item item)
    {
        if (item.SellIn > 0)
        {
            item.Quality -= 1;
        }
        else
        {
            item.Quality -= 2;
        }
    }
}