namespace mathGameOOP4
{
    internal class Menu
    {
        GameEngine gameEngine = new(); // Uvedu pro tuto třídu gameEngine class.
        internal void ShowMenu(string name, DateTime date) // internal - vše ve třídě patří třídě, dostupno z jiných částí projektu..
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
