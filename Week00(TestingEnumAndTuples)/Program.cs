using System.Diagnostics;

class Program
{
    const string Player1 = "Player 1";
    const string Player2 = "Player 2";

    public static void RunTests()
    {
        TestStickPickUpCountIsValid();
        TestGetNewPlayer();
        Console.WriteLine("All tests passed");

    }
    public static void Main(string[] args)
    {
        RunTests();
        var sticks = 10;
        var currentPlayer = Player1;
        var history = new List<int>();
        DisplayStatusToUser(sticks, currentPlayer);

        while (sticks > 0)
        {
            int sticksPickedUp = GetStickCountFromUser();
            var stickCountValid = StickPickUpCountIsValid(sticksPickedUp, sticksPickedUp);
            if (!stickCountValid)
            {
                Console.WriteLine("Invalid count of sticks picked up");
                return;
            }

            history.Add(sticksPickedUp);
            sticks -= sticksPickedUp;
            currentPlayer = GetNewPlayer(currentPlayer);
            DisplayStatusToUser(sticks, currentPlayer);
        }

        Console.WriteLine($"{currentPlayer} has lost!");

        var turn = 0;
        foreach (var item in history)
        {
            Console.WriteLine($"Turn {turn} - stick: {item}");
            turn++;
        }
    }

    public static bool StickPickUpCountIsValid(int stickCount, int stickTotal)
    {
        if (stickCount > 3)
            return false;
        if (stickCount > stickTotal)
            return false;
        if (stickCount < 1)
            return false;
        return true;
    }

    public static string GetNewPlayer(string currentPlayer)
    {
        if (currentPlayer == Player1)
            return Player2;
        else
            return Player1;
    }


    public static void TestStickPickUpCountIsValid()
    {
        Debug.Assert(StickPickUpCountIsValid(30, 10) == false);
        Debug.Assert(StickPickUpCountIsValid(3, 10) == true);
        Debug.Assert(StickPickUpCountIsValid(3, 2) == false);
        Debug.Assert(StickPickUpCountIsValid(3, 3) == true);
        Debug.Assert(StickPickUpCountIsValid(1, 1) == true);
        Debug.Assert(StickPickUpCountIsValid(2, 1) == false);
    }

    public static void TestGetNewPlayer()
    {
        Debug.Assert(GetNewPlayer(Player1) == Player2);
        Debug.Assert(GetNewPlayer(Player2) == Player1);
    }

    public static int GetStickCountFromUser()
    {
        Console.WriteLine("How many sticks would like to pick up?");
        var userInput = Console.ReadLine();
        var sticksPickedUp = int.Parse(userInput ?? "-1");
        return sticksPickedUp;
    }

    public static void DisplayStatusToUser(int sticks, string currentPlayer)
    {
        Console.WriteLine($"There are {sticks} sticks, it is {currentPlayer} turn's");
    }
}