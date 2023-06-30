public class DesiredOrder
{
    public List<MenuItem> MenuItems { get; }
    public DesiredOrder(List<MenuItem> menuItems)
    {
        MenuItems = menuItems;
    }
    public static DesiredOrder? Create(List<MenuItem> menuItems)
    {
        return new DesiredOrder(menuItems);
    }

    public int GetTotalCost()
    {
        var totalCost = 0;
        foreach (var menuItem in MenuItems)
        {
            totalCost += menuItem.CostInCents;
        }
        return totalCost;
    }
}