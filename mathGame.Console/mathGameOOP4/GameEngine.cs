namespace mathGameOOP4
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, "Division");
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void AdditionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Addition"); // Internal (není private), static (nemusím jí deklarovat v jádru programu.cs)
        }

    }
}
