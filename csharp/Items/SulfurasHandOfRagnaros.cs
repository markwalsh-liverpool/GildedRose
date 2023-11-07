namespace csharp.Items;

public class SulfurasHandOfRagnaros : BaseItem
{
    protected override int MaximumQuality => 80;

    public override void UpdateItem(Item item)
    {
        item.Quality = MaximumQuality;
    }
}