public class CreditCard
{
    public string CardNumber { get; }
    private CreditCard(string cardNumber)
    {
        CardNumber = cardNumber;
    }

    public static CreditCard? Create(string cardNumber)
    {
        if(cardNumber.Length != 19)
        {
            return null;
        }

        if(hasLetters(cardNumber))
        {
            return null;
        }

        return new CreditCard(cardNumber);
    }

    private static bool hasLetters(string cardNumber)
    {
        foreach(var character in cardNumber)
        {
            if(char.IsLetter(character))
            {
                return true;
            }
        }

        return false;
    }
}