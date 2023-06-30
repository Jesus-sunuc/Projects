public class Cashier
{
    public OrderHistory OrderHistory { get; }
    public Cashier(OrderHistory orderHistory)
    {
        OrderHistory = orderHistory;
    }

    public void ProcessOrder(Customer customer)
    {
        if(!CustomerHasEnoughCash(customer))
        {
            Console.WriteLine("Customer does not have enough cash");
        }
        else
        {
            var paymentMethod = GetCustomerPaymentMethod(customer);
            var cost = customer.DesiredOrder.GetTotalCost();
            var transaction = new Transaction(cost, paymentMethod);
            var newOrder = new CustomerOrder(transaction, customer.DesiredOrder.MenuItems);
            OrderHistory.CustomerOrders.Add(newOrder);
        }
    }

    private static bool CustomerHasEnoughCash(Customer customer)
    {
       var orderAmount = customer.DesiredOrder.GetTotalCost();
       if(customer.Wallet.CashAmount > orderAmount)
       {
            return true;
       }

       if(customer.Wallet.CreditCard is not null)
       {
            return true;
       }

       return false;
    }

    private static PaymentMethod GetCustomerPaymentMethod(Customer customer)
    {
        var orderAmount = customer.DesiredOrder.GetTotalCost();
        if(customer.Wallet.CashAmount > orderAmount)
        {
            return PaymentMethod.Cash;
        }
        else
        {
            return PaymentMethod.CreditCard;
        }
    }

}