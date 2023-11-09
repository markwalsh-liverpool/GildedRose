using csharp.Items.Base;

namespace csharp.Items;

public class BackstagePasses : VariableQualityBaseItem
{
    protected override void AdjustQuality(Item item)
    {
        switch (item.SellIn)
        {
            case > 10:
                item.Quality += 1;
                break;
            case > 5:
                item.Quality += 2;
                break;
            case > 0:
                item.Quality += 3;
                break;
            default:
                item.Quality -= item.Quality;
                break;
        }
    }
}