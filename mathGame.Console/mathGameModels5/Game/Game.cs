namespace mathGameModels5.Game; // Dvojtečkou zjednoduším usings apod.

internal class Game
{
    //private int _score; // Private, odjinud než zde se k tomu nedostanu.

    //public int Score // Public, odevšud se dostanu.
    //{ 
    //    get { return _score; } // Mohu v publicu GETnout privatní hodnotu.
    //    set { _score = value; } // Mohu ji změnit.
    //}

    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; } // Enumerace - showcase
}

// Enumerace se píší až pod jádro kódu.
// Enumerace se pak nabízí v nabídce možností při psaní kodu.
internal enum GameType  // Enumerace, díky kterým jde použít více datových formátů (Date and Time etc.)
{
    Division,
    Multiplication,
    Subtraction,
    Addition
}
