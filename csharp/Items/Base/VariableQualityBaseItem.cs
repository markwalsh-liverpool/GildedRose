using System;

namespace csharp.Items.Base;

public abstract class VariableQualityBaseItem : BaseItem
{
    protected const int MinimumQuality = 0;

    protected const int MaximumQuality = 50;

    protected abstract void AdjustQuality(Item item);

    public override void UpdateItem(Item item)
    {
        AdjustQuality(item);

        item.Quality = Math.Clamp(item.Quality, MinimumQuality, MaximumQuality);

        item.SellIn -= 1;
    }
}