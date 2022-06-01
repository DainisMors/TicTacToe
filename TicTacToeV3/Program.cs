using TicTacToeV3;

string ret = "";
int symbol = 0;
string displayInfo = "Jāievada koordinātes, piemēram 1a vai b3... utt, pēc tam Enter. Ievadot X spēle beidzas.";


Console.Clear();
Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
Console.WriteLine(displayInfo);
Console.WriteLine("");

string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
string[] user = { "x", "o" };
Data.DisplayBoard(info);


for (int i = 0; i < (info.Length) * 2; i++)
{
    ret = Console.ReadLine();
    if (ret.ToLower() == "x")
    {
        Console.WriteLine("Paldies! Tiekamies citreiz! :)");
        break;
    }
    ret = Data.CheckAndOrder(ret);

    if (ret.Length == 2)
    {
        info = Data.FillDisplayInfo(info, "x", ret);
//        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(displayInfo);
        Console.WriteLine("");
        Data.DisplayBoard(info);

    }
    if (i == (info.Length *2 - 1))
    {
        Console.WriteLine("Paldies! Šoreiz pietiks spēlēts! Tiekamies citreiz! :)");
    }
}


