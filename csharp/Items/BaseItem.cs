namespace csharp.Items;

public abstract class BaseItem : Item
{
    public abstract void UpdateItem(Item item);

    protected const int MinimumQuality = 0;

    protected abstract int MaximumQuality { get; }

    protected bool QualityIsAboveMinimum(int quality)
    {
        return quality > MinimumQuality;
    }

    protected bool QualityIsAboveMaximum(int quality)
    {
        return quality > MaximumQuality;
    }

    protected bool QualityIsBelowMinimum(int quality)
    {
        return quality < MinimumQuality;
    }

    protected bool QualityIsBelowMaximum(int quality)
    {
        return quality < MaximumQuality;
    }
}