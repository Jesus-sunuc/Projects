public class CreditCardTests
{
    [Test]
    public void TestCreditCardCreate()
    {
        var creditCard = CreditCard.Create("4444 4444 4444 4444");
        Assert.IsNotNull(creditCard);
    }

    [Test]
    public void TestCreditCardCreateWithWithWrongLenght()
    {
        var creditCard = CreditCard.Create("4444 4444 4444 444");
        Assert.IsNull(creditCard);
    }

    [Test]
    public void TestCreditCardCreateWithWithBadLetter()
    {
        var creditCard = CreditCard.Create("4444 4444 4444 4z44");
        Assert.IsNull(creditCard);
    }
}