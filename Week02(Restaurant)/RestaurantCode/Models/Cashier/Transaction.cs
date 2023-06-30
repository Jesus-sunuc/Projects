//****Transaction class needs to be fixed, the whole program is not working because of that****

public class Transaction 
{
    public int AmountInCents { get; }
    public PaymentMethod PaymentMethod { get; }

    public Transaction(int amountInCents, PaymentMethod paymentMethod)
    {
        AmountInCents = amountInCents;
        PaymentMethod = paymentMethod;
    }

    public static Transaction? Create(int amountInCents, PaymentMethod paymentMethod)
    {
        if (amountInCents == 0)
            return null;

        return new Transaction(amountInCents, paymentMethod);
    }
}

public enum PaymentMethod
{
    Cash,
    CreditCard
}
