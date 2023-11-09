using csharp.Items.Base;

namespace csharp.Items;

public class SulfurasHandOfRagnaros : BaseItem
{
    public override void UpdateItem(Item item)
    {
        item.Quality = 80;
    }
}