using mathGameModels5.Game;

namespace mathGameOOP4
{
    internal class Helpers
    {
        // List(Game) model.
        // LINQ (Query of simple data in cSharp) Showcase
        internal static List<Game> games = new List<Game> // Takzvaný field - list je použitelný kdekoliv a v jakémkoliv souboru // části proj.
        {   
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };



        internal static void PrintGames() // Internal (není private), static (nemusím jí deklarovat v jádru programu.cs)
        {
            //LINQ vypsaní z databaze
            //var gamesToPrint = games.Where(x => x.Type == GameType.Addition); //Tisk všech sčítacích her.
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09) ); //Tisk her hraných po 9.8.2022

            var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09)).OrderByDescending(x => x.Score); //Vypíše data od daného data dále a také seřadí podle score hračů od zhora dolů. 

            // Klasicke vypsani zahranych her, bez databaze.
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            foreach (var game in gamesToPrint) // in 1(games) no LINQ, 2(gamesToPrint) LINQ
            {
                Console.WriteLine($"{game.Date} - {game.Score}: {game.Type}");
            }
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }

        // Models showcase!
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            //games.Add($"{game.date} - {gameType}: {gameScore} pts"); - zapis bez uziti modelu.
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
                // Get; Set;
                // V třídě GameEngine řádky s fcí AddToHistory - ukázka funkčnosti, nyní jsou typy her v nabídce proj.
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}
