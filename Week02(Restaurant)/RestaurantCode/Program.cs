public class Restaurant
{

}

class program
{
    static void Main(string[] args)
    {
        MenuItem? toast = MenuItem.Create("toast", 351);

        if(toast == null)
        {
           return;
        }
    }
}