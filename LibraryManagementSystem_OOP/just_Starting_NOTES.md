Poznámky.

Typy proměnných
- string - pro slova, fráze nebo jakákoli alfanumerická data pro prezentaci, ne výpočet
- char - pro jeden alfanumerický znak
- int - pro celé číslo
- decimal - pro číslo se zlomkovou komponentou
- bool - true/false - pro hodnotu


Proměnné - Definice
- Proměnné jsou dočasné hodnoty, které ukládáte do paměti počítače.
- Proměnnou musíte napřed deklarovat, abyste ji mohli použít.
- Pokud chcete deklarovat proměnnou, nejprve vyberte datový typ, který dopovídá druhu uložených dat, a pak proměnnou pojmenujte. Dodržujte při tom uvedená pravidla.

Práce s proměnnými
- Před načtením (získání) hodnoty z proměnné musíte přiřadit (nastavit) hodnotu proměnné.
- Proměnnou můžete inicializovat přiřazením hodnoty proměnné v okamžiku deklarace.
- Zadání probíhá zprava doleva.
Jako operátor přiřazení použijete jeden znak rovná se.
- Pokud chcete načíst hodnotu z proměnné, použijte pouze název proměnné.

Implicitní proměnná - (var)
- Klíčové slovo var říká kompilátoru, aby datový typ proměnné odvodil na základě hodnoty, do které je inicializovaný.
- Při čtení kódu jiných lidí se pravděpodobně zobrazí var klíčové slovo. Pokud je to ale možné, měli byste datový typ použít.

Formátování textu v řetězcích pomocí UNICODE
- Pokud potřebujete do řetězce literálu vložit speciální znak, jako je tabulátor \t, nový řádek \n nebo dvojité uvozovky \", použijte řídicí sekvence znaků.
- Pokud potřebujete použít zpětné lomítko v jakékoli jiné situaci, použijte jeho řídicí znak \\.
- Direktiva @ slouží k vytvoření doslovného řetězcového literálu, který uchovává veškeré formátování prázdných znaků a zpětné lomítko v řetězci.
- Pokud chcete v řetězci vyjádřit znaky Unicode (UTF-16), použijte řídicí znak \u a příslušný čtyřmístný kód.
- Znaky Unicode se nemusí správně tisknout v závislosti na aplikaci.

Interpolace řetězců 
EXAMPLES
- int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);
- string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
Dolar = interpolace, Zavináč = Dají se použít i / -> třeba string projectName = "First-Project";  Console.WriteLine($@"C:\Output\{projectName}\Data");

Operace s čísly
- S čísly můžete provádět matematické operaci, jako je sčítání.
- Znaménko plus + se používá jak ke spojování, tak ke sčítání řetězců. Tomuto stavu se říká přetížení operátoru. Kompilátor odvodí správný způsob použití operátoru podle použitých datových typů operandů.
- Pokud je zřejmé, že se vývojář snaží spojit řetězcovou reprezentaci čísla s jiným řetězcem pro účely prezentace, tak kompilátor jazyka C# implicitně převede typ int na typ string (když je to možné).
- Pomocí závorek definujte pořadí operací, abyste explicitně řekli kompilátoru, že chcete provést určité operace před jinými operacemi.

Přetypování čísel z celých na desetinné
- int first = 7;
  int second = 5;
  decimal quotient = (decimal)first / (decimal)second;
  Console.WriteLine(quotient);

- Pomocí % (např. 10%8) nám výsledek vyhodí zbytek po dělení, v tomto případě tedy 2.


REKAPITULACE Operací s čísly
- Základní matematické operace se provádějí pomocí operátorů +, -, * a /.
- Když vydělíte dvě hodnoty typu int, ve výsledku se oříznou všechny hodnoty za desetinnou čárkou (tečkou). Pokud chcete zachovat hodnoty za desetinnou čárkou, musíte dělitele nebo dělitele (nebo obojí) přetypovat na int číslo s plovoucí desetinnou čárkou, jako decimal je číslo s plovoucí desetinnou čárkou, a potom musí být podíl stejného typu s plovoucí desetinnou čárkou, aby nedocházelo ke zkrácení.
- Operace přetypování způsobí, že se s hodnotou bude dočasně zacházet tak, jako by šlo o jiný datový typ.
- Operátor % umožňuje získat zbytek po dělení.
- Operace se provádějí v pořadí: závorky, umocňování, násobení a dělení (zleva doprava), sčítání a odčítání (zleva doprava).

Složené operátory přiřazení
- Operátory +=, -=, *=, ++ a -- se nazývají složené operátory přiřazení, protože před operací přiřazení provedou ještě další operaci a její výsledek přiřadí proměnné. Například operátor += se nazývá složený operátor sčítání a přiřazení.
- int value = 0;     // value is now 0.
  value = value + 5; // value is now 5.
  value += 5;        // value is now 10.
- int value = 0;     // value is now 0.
  value = value + 1; // value is now 1.
  value++;           // value is now 2.
  
- Složené operátory přiřazení +=, -=, *=, ++ a -- slouží k provádění matematických operací, jako je inkrementace nebo dekrementace, a k následnému přiřazení výsledku do původní proměnné.
- Operátory inkrementace a dekrementace fungují různě v závislosti na tom, jestli příslušný operátor je před operandem nebo za ním.

EXAMPLE Data typy a převody
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

