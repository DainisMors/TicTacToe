using TicTacToeV3;

string ret = "";
int symbol = 0;      

Console.Clear();
Console.WriteLine("Sveiks, spēlējam, tavs gājiens");
Console.WriteLine("Jāievada koordinātes, piemēram 1a vai 3b, vai a1, vai ... utt, pēc tam Enter");
Console.WriteLine("");

string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
Data.DisplayBoard(info);


for (int i = 0; i < (info.Length) * 2; i++)
{
    ret = Console.ReadLine();
    ret = Data.checkAndOrder(ret);

    if (ret.Length == 2)
    {
        info[1] = ret.Substring(0, 1);
        info[2] = ret.Substring(1, 1);
        Console.Clear();
        Console.WriteLine("Jāievada koordinātes, piemēram 1a vai 3b, vai a1, vai ... utt, pēc tam Enter");
        Console.WriteLine("");
        Data.DisplayBoard(info);

    }


}


