public class Restaurant
{
    public Menu Menu { get; }
    public CustomerQueue CustomerQueue { get; }
    public Cashier Cashier { get; }
    public Restaurant(Menu menu, CustomerQueue customerQueue, Cashier cashier)
    {
        Menu = menu;
        CustomerQueue = customerQueue;
        Cashier = cashier;
    }


}