using static System.Formats.Asn1.AsnWriter;

namespace mathGameSwitch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.UtcNow;

            string name = GetName();

            var games = new List<string>(); // Deklarace nového prázdného Listu.

            Menu(name);// Right-click - refaktoring - lze kus kódu sbalit do metody, aby program nezabíral tolik místa.

            // Metody
            string GetName()
            {
                Console.WriteLine("Prosím, zadejte své jméno");
                var name = Console.ReadLine();
                return name;
            }

            void Menu(string name)
            {
                // ToUpper, DayOfWeek - Metody tříd jazyku C#
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"Přihlášen, {name.ToUpper()}! Dnes je {date}. Vítej v matematické hře! Je super, že se chceš zdokonalovat ve svých \ndovednostech.");
                Console.WriteLine("\n"); // Nový řádek

                var isGameOn = true;

                do // Dokud je isgameOn true, bude se nabídka stále opakovat a obnovovat.
                {
                    Console.Clear();
                    Console.WriteLine($@"Co bys chtěl procvičovat dneska? Vyber si z možností, které jsou uvedeny níže:
A - Sčítání
S - Odčítání
M - Násobení
D - Dělení
L - Historie a skóre hraných her
Q - Ukončit procvičování"); // @ zanechá tabulátory v textu jako tady v kódu, stejně.
                    Console.WriteLine("-----------------------------------------------");

                    var gameSelected = Console.ReadLine();

                    // SWITCH Metoda
                    switch (gameSelected.Trim().ToLower())
                    {
                        case "a":
                            AdditionGame("Cvičení pro trénink sčítání");
                            break;
                        case "s":
                            SubstractionGame("Cvičení pro trénink odčítání");
                            break;
                        case "m":
                            MultiplicationGame("Cvičení pro trénink násobení");
                            break;
                        case "d":
                            DivisionGame("Cvičení pro trénink dělení");
                            break;
                        case "q":
                            Console.WriteLine("Nashledanou!");
                            isGameOn = false;
                            break;
                        case "l":
                            GetGames();
                            break;
                        default:
                            Console.WriteLine("Zadal jsi neplatnou možnost. Vyber si možnost z nabídky.");
                            break;
                    }
                } 

                while (isGameOn);

            }

            void AdditionGame(string message)
            {
                var Random = new Random();
                var score = 0; // Počítadlo udělaných cvičení

                int firstNum;
                int secondNum;


                for (int i = 0; i < 5; i++) // Počítadlo, délka, každý cyklus další krok.
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNum = Random.Next(1, 9);
                    secondNum = Random.Next(1, 9);

                    Console.WriteLine($"{firstNum} + {secondNum}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNum + secondNum)
                    {
                        Console.WriteLine($"Správně!");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Výsledek je špatně.");
                        Console.ReadLine();
                    }
                    if (i == 4)
                    {
                        Console.WriteLine($"Lekce je u konce. Tvé konečné skóre je {score}. Zmačkni cokoliv pro návrat do menu.");
                        Console.ReadLine();
                    }
                }
                AddToHistory(score, "Sčítání");
                // games.Add($"{DateTime.Now} - Sčítání: Skóre - {score}"); -> Pokud bych nevytvořil metodu..
            }

            void SubstractionGame(string message)
            {
                var Random = new Random();
                var score = 0; // Počítadlo hotových příkladů

                int firstNum;
                int secondNum;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNum = Random.Next(1, 9);
                    secondNum = Random.Next(1, 9);

                    Console.WriteLine($"{firstNum} - {secondNum}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNum - secondNum)
                    {
                        Console.WriteLine($"Správně! Zmačkni libovolné tlačítko pro krok dál.");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Výsledek je špatně. Zmačkni libovolné tlačítko pro krok dál.");
                        Console.ReadLine();
                    }
                    if (i == 4)
                    {
                        Console.WriteLine($"Lekce je u konce. Tvé konečné skóre je {score}. Zmačkni cokoliv pro návrat do menu.");
                        Console.ReadLine();
                    }
                }
                AddToHistory(score, "Odčítání");
            }

            void MultiplicationGame(string message)
            {
                var Random = new Random();
                var score = 0; // Počítadlo hotových příkladů

                int firstNum;
                int secondNum;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNum = Random.Next(1, 9);
                    secondNum = Random.Next(1, 9);

                    Console.WriteLine($"{firstNum} * {secondNum}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNum * secondNum)
                    {
                        Console.WriteLine($"Správně! Zmačkni libovolné tlačítko pro krok dál.");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Výsledek je špatně. Zmačkni libovolné tlačítko pro krok dál.");
                        Console.ReadLine();
                    }
                    if (i == 4)
                    {
                        Console.WriteLine($"Lekce je u konce. Tvé konečné skóre je {score}. Zmačkni cokoliv pro návrat do menu.");
                        Console.ReadLine();
                    }
                }
                AddToHistory(score, "Násobení");
            }
            
            void DivisionGame(string message)
            {
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    var divisionNumbers = GetDivisionNumbers();
                    var firstNum = divisionNumbers[0];
                    var secondNum = divisionNumbers[1];

                    Console.WriteLine($"{firstNum} / {secondNum}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNum / secondNum)
                    {
                        Console.WriteLine("Správně! Zmačkni libovolné tlačítko pro krok dál.");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Výsledek je špatně. Zmačkni libovolné tlačítko pro krok dál.");
                        Console.ReadLine();
                    }
                    if (i == 4)
                    {
                        Console.WriteLine($"Lekce je u konce. Tvé konečné skóre je {score}. Zmačkni cokoliv pro návrat do menu.");
                        Console.ReadLine();
                    }
                }
                AddToHistory(score, "Dělení");

            }

            //ARRAYS - int[]
            int[] GetDivisionNumbers()
            {
                var random = new Random();
                var firstNum = random.Next(1, 99);
                var secondNum = random.Next(1, 99);

                var result = new int[2]; // Array který bude obsahovat 2 číslice.

                while (firstNum % secondNum != 0) // Opakuje se dokud nebude splněna podmínka. != je negace, takže pokud to není nula, platí a bude se opakovat.
                {
                    firstNum = random.Next(1, 99);
                    secondNum = random.Next(1, 99);
                }

                result[0] = firstNum;
                result[1] = secondNum;

                Console.WriteLine(result);
                return result;
            }

            void GetGames() // Vlastně jenom vypsání hodnot v Listu.
            {
                Console.Clear();
                Console.WriteLine("Historie zahraných her");
                Console.WriteLine("----------------------------");
                foreach (var game in games) // Deklarace var game, games je deklarovaný list na začátku .proj.
                {
                    Console.WriteLine(game);
                }
                Console.WriteLine("----------------------------\n");
                Console.WriteLine("Zmačkněte libovolnou klávesu pro návrat do menu.");
                Console.ReadLine();
            }

            void AddToHistory(int courseScore, string courseName)
            {
                games.Add($"{DateTime.Now} - {courseName}: {courseScore} pts");
            }


            Console.ReadKey();
        }
    }
}
