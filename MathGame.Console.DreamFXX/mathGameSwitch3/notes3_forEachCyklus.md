          //Demonstrace funkce pro foreach cyklus.
          //Foreach se opakuje tolikrát, kolikrát se z kolekce shodne daná podmínka // hodnota (V tomto případě hodnoty z arraye.)
          
          int[] GetDivisionNumbers()
            {
                var random = new Random();
                var firstNum = random.Next(0, 99);
                var secondNum = random.Next(0, 99);

                var result = new int[2]; // Array který bude obsahovat 2 číslice.

                foreach (var number in result) //foreach se opakuje tolikrát, kolikrát se z arraye shoduje hodnot s podmínkou.
                {
                    Console.WriteLine($"Čísla z posloupnosti - {number}");
                }

                result[0] = firstNum;
                result[1] = secondNum;

                Console.WriteLine(result);
                return result;
            }


// do while - opakuje se neustále, při čemž platí podmínka. jakmile podmínka přestane platit, přestane se opakovat.
do
{
    Console.WriteLine();
} while (isGameOn = true); // Bude vypisovat dokud bude gameOn = true


// Přidávání do hodnot (řetězců) do Listu
games.Add($"{DateTime.Now} - Sčítání: Skóre - {score}");
