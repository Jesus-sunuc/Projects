public class Menu
{
    public List<MenuItem> MenuItems { get; }
    private Menu (List<MenuItem> menuItems)
    {
        MenuItems = menuItems;
    }

    public static Menu? Create(List<MenuItem> menuItems)
    {
        if(menuItems.Count == 0)
        {
            return null;
        }

        return new Menu(menuItems);
    }
}