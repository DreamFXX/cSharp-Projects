namespace mathGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosím, zadejte své jméno");

            var name = Console.ReadLine();
            var date = DateTime.UtcNow;

            // ToUpper, DayOfWeek - Metody tříd jazyku C#
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Přihlášen, {name.ToUpper()}! Dnes je {date}. Vítej v matematické hře! Je super, že se chceš zdokonalovat ve svých dovednostech.");
            Console.WriteLine("\n"); // Nový řádek
            Console.WriteLine($@"Co bys chtěl procvičovat dneska? Vyber si z možností, které jsou uvedeny níže:
            A - Sčítání
            S - Odčítání
            M - Násobení
            D - Dělení
            Q - Ukončit procvičování");
            Console.WriteLine("---------------------------------------------");

            var gameSelected = Console.ReadLine();

            if (gameSelected.Trim().ToLower() == "a") // Trim - smazaní mezer apod., ToLower - capslock změní na malé.
            {
                AdditionGame();
            }

            else if (gameSelected.Trim().ToLower() == "s") //CTRL + SHIFT + H -> najít a nahradit (gameselected + trim to lower...)
            {
                SubstractionGame();
            }

            else if (gameSelected.Trim().ToLower() == "m")
            {
                MultiplicationGame();
            }

            else if (gameSelected.Trim().ToLower() == "d")
            {
                DivisionGame();
            }

            else if (gameSelected.Trim().ToLower() == "q")
            {
                Console.WriteLine("Nashledanou!");
                Environment.Exit(1);
            }

            else
            {
                Console.WriteLine("Zadal jsi neplatné písmeno. Vybírej z možností z nabídky.");
            }

            // Metody
            void AdditionGame()
            {
                Console.WriteLine("Cvičení na sčítání začalo!");
            
            }

            void SubstractionGame()
            {
                Console.WriteLine("Cvičení na odčítání začalo!");
            }

            void MultiplicationGame()
            {
                Console.WriteLine("Cvičení na násobení začalo!");
            }

            void DivisionGame()
            {
                Console.WriteLine("Cvičení na dělení začalo!");
            }

            Console.ReadKey();
        }
    }
}
