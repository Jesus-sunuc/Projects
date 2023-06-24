public class Wallet
{
    public uint CashAmount { get; }
    public CreditCard CreditCard { get; }
    public  Wallet(uint cashAmount, CreditCard creditCard)
    {
        CashAmount = cashAmount;
        CreditCard = creditCard;
    }
}