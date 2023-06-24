public class MenuItem
{
    public string Title { get; set; }
    public int CostInCents { get; set; }

    private MenuItem(string title, int costInCents)
    {
        Title = title;
        CostInCents = costInCents;
    }

    public static MenuItem? Create(string title, int costInCents)
    {
        if(costInCents >= 100_000)
        {
            return null;
        }

        return new MenuItem(title, costInCents);
    }

}