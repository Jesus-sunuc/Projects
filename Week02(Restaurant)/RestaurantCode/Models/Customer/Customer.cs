public class Customer
{
    public Wallet Wallet { get; }
    public DesiredOrder DesiredOrder { get; }

    public Customer(Wallet wallet, DesiredOrder desiredOrder)
    {
        Wallet = wallet;
        DesiredOrder = desiredOrder;
    }
}