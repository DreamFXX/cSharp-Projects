namespace mathGame1
{
    internal class Program
    {
        // Publish a project - sestavení, publikovat výběr.. sestaví exe soubor.
        static void Main(string[] args)
        {
            int index = 1;
            string name = "Pablo";
            char initial = 'P';
            int year = 2022;
            decimal height = 1.85m;
            bool doWeLoveToCode = true;

            Console.WriteLine("These are the most common data types:\n"); // Lomeno n - nový řádek.
            Console.WriteLine($"{index++} +  - string , Example:  + {name}"); //Interpolace
            Console.WriteLine(index++ + " - char , Example: " + initial);
            Console.WriteLine(index++ + " - int , Example: " + year);
            Console.WriteLine(index++ + " - decimal , Example: " + height);
            Console.WriteLine(index++ + " - bool  , Example: " + doWeLoveToCode);

            Console.ReadKey();
        }
    }
}
