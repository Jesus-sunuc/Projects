public class RestaurantUserInterfaceTests
{
    [Test]
    public void TestDisplayCustomers()
    {
        var restaurant = CreateTestRestaurant();
        var ui = new RestaurantUserInterface(restaurant);
        var expectedOutput = @"
        1: DesiredOrder - bacon
        ";
      
      var actualOutput = ui.DisplayCustomers();
      Assert.AreEqual(expectedOutput.Replace("\r", ""), actualOutput);
    }

    private static Restaurant CreateTestRestaurant()
    {
        var wallet = new Wallet(100_000, null!);
        var menuItem = MenuItem.Create("bacon", 200);
        if (menuItem == null)
            Assert.Fail();
        var desiredOrder = DesiredOrder.Create(new List<MenuItem>() { menuItem! });

        var customer = new Customer(wallet, desiredOrder!);
        var queue = new CustomerQueue();
        queue.Customers.Add(customer);

        var menu = Menu.Create(new List<MenuItem>() { menuItem! });

        if (menu == null)
            Assert.Fail();

        var orderHistory = new OrderHistory();
        var cashier = new Cashier(orderHistory);

        return new Restaurant(menu!, queue, cashier);
    }
}