using csharp.Items.Base;

namespace csharp.Items;

public class ConjuredManaCake : VariableQualityBaseItem
{
    protected override void AdjustQuality(Item item)
    {
        item.Quality -= 2;
    }
}