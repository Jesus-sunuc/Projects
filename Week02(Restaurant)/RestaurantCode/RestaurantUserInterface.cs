public class RestaurantUserInterface
{
    public Restaurant Restaurant { get; }
    public RestaurantUserInterface(Restaurant restaurant)
    {
        Restaurant = restaurant;
    }

    public string DisplayCustomers()
    {
        var output = "\n";
        var count = 1;
        foreach (var customer in Restaurant.CustomerQueue.Customers)
        {
            var firstPart = $"        {count}: DesiredOrder - ";
            var titlesList = new List<string>();
            foreach (var item in customer.DesiredOrder.MenuItems)
            {
                titlesList.Add(item.Title);
            }

            var secondPart = String.Join(", ", titlesList);
            output += $"{firstPart}{secondPart}\n        ";
            count++;
        }

        return output;
    }

    public string DisplayHistoryTotal()
    {
        var output = "\n";
        var total = 0;
        var count = 0;
        foreach (var order in Restaurant.Cashier.OrderHistory.CustomerOrders)
        {
            var amount = order.Transaction.AmountInCents;
            total += amount;
            var titlesList = new List<string>();
            foreach (var item in order.MenuItems)
            {
                titlesList.Add(item.Title);
            }

            var menuItemTitles = String.Join(", ", titlesList);
            output += $"{count}: {amount} - {menuItemTitles}\n";
            count++;
        }

        output += $"Total: {total}\n";
        return output;
    }

    public string? DisplayMenu()
    {
        return @"
        Welcome to the Restaurant
        Please select an option:
        1. Display Customer Queue
        2. Serve Next Customer
        3. Print Order history
        q. Quit
        ";
    }
    

    public string? ProcessUserInput(string userInput)
    {
        // while (userInput != "1" && userInput != "2" && userInput != "3")
        while(true)
        {
            switch (userInput)
            {
                case "1":
                    return DisplayCustomers() + DisplayMenu();
                case "2":
                    var nextCustomer = Restaurant.CustomerQueue.GetCustomerToServe();
                    Restaurant.Cashier.ProcessOrder(nextCustomer);
                    return DisplayMenu();
                case "3":
                    return DisplayHistoryTotal() + DisplayMenu();
                case "q":
                    return null;
                default:
                    Console.WriteLine("Invalid input");
                    userInput = Console.ReadLine()?? "";
                    break;
            }
        }
    }
}