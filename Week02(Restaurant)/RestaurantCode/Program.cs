class Program
{
    public static void Main(string[] args)
    {
        var restaurant = CreateBaseRestaurant();
        var ui = new RestaurantUserInterface(restaurant);

        string? nextOutput = ui.DisplayMenu();
        while (nextOutput != null)
        {
            Console.WriteLine(ui.DisplayMenu());
            var userInput = Console.ReadLine() ?? "";
            nextOutput = ui.ProcessUserInput(userInput);
        }
    }

     private static Restaurant CreateBaseRestaurant()
    {
        var wallet = new Wallet(100_000, null!);
        var menuItem1 = MenuItem.Create("bacon", 200);
        var menuItem2 = MenuItem.Create("cheese", 300);

        var desiredOrder = DesiredOrder.Create(new List<MenuItem>() { menuItem1! });
        var customer1 = new Customer(wallet, desiredOrder!);
        var customer2 = new Customer(wallet, desiredOrder!);
        var queue = new CustomerQueue();
        queue.Customers.Add(customer1);
        queue.Customers.Add(customer2);

        var menu = Menu.Create(new List<MenuItem>() { menuItem1!, menuItem2! });

        var orderHistory = new OrderHistory();
        var cashier = new Cashier(orderHistory);

        return new Restaurant(menu!, queue, cashier);
    }
}