using csharp.Items;

namespace csharp.Factories.Interfaces;

public interface IItemFactory
{
    BaseItem CreateItem(string itemName);
}