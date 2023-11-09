using csharp.Items.Base;

namespace csharp.Factories.Interfaces;

public interface IItemFactory
{
    BaseItem CreateItem(string itemName);
}