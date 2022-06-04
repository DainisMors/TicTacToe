using TicTacToeV3;

string ret = "";
int symbol = 0;

Console.Clear();
Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
Console.WriteLine("");

string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
string[] user = { "x", "o" };
int defUser = 0;
Data.DisplayBoard(info);


for (int i = 0; i < (info.Length) * 2; i++)
{
    ret = Console.ReadLine();
    if (ret.ToLower() == "x")
    {
        Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
        break;
    }
    ret = Data.CheckAndOrder(ret);

    if (ret.Length == 2)
    {
        defUser = (defUser + 1) % 2;
        info = Data.FillDisplayInfo(info, user[defUser], ret);
/*
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(displayInfo);
        Console.WriteLine("");
        Data.DisplayBoard(info);
*/
    }
    if (i == (info.Length *2 - 1))
    {
        Console.WriteLine("Paldies! Šoreiz pietiks spēlēts! Tiekamies citreiz! :)");
    }
}


