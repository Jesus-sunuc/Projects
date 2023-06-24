namespace RestaurantTests;
public class MenuItemTests
{
    [Test]
    public void TestMenuItemBuilderWithValidInputs()
    {
        var newMenuItem = MenuItem.Create("toast", 351);
        Assert.IsNotNull(newMenuItem);
    }

    [Test]
    public void TestMenuItemBuilderWithInvalidInputs()
    {
        // 100_000 is an invalid cost for a menu item
        var newMenuItem = MenuItem.Create("toast", 351_000_000);
        Assert.IsNull(newMenuItem);
    }
}