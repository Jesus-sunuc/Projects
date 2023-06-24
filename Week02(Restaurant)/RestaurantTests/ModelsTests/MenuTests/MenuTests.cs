public class MenuItemTests
{
    [Test]
    public void TestMenuCreate()
    {
        var item1 = MenuItem.Create("toast", 40);
        if(item1 == null)
        {
            Assert.Fail();
        }
        else 
        {
            var list = new List<MenuItem>() {item1};
            var menu = Menu.Create(list);

            Assert.AreEqual(menu?.MenuItems[0], item1);
        }
    }

    [Test]
    public void TestMenuCreateCheckNonEmptyList()
    {
        var emptyList = new List<MenuItem>();
        var menu = Menu.Create(emptyList);

        Assert.IsNull(menu);
    }
}