using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV3
{
    public class TicTacToEksperiments
    {
        public void runGame()
        {
            string ret = "";
            string retOrig = "";
            int symbol = 0;

            Console.Clear();
            Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
            Console.WriteLine("");

            string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] user = { "x", "o" };
            string[] log = { "x: ", "o: " };

            int defUser = 1;
            Data.DisplayBoard(info, log);


            for (int i = 0; i < (info.Length) * 2; i++)
            {
                ret = Console.ReadLine();
                retOrig = ret;
                if (ret.ToLower() == "x")
                {
                    Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
                    break;
                }
                ret = Data.CheckAndOrder(ret);

                if (ret.Length == 2)
                {
                    defUser = (defUser + 1) % 2;
                    log[defUser] = log[defUser] + " " + retOrig;
                    info = Data.FillDisplayInfo(info, user[defUser], ret, log);
                }
                if (i == (info.Length * 2 - 1))
                {
                    Console.WriteLine("Paldies! Šoreiz pietiks! Tiekamies citreiz! :)");
                }
            }
            //ILogEksports
            Email email = new Email();
            Printer printer = new Printer();

            List<ILogEksports> loges = new List<ILogEksports>();
            loges.Add(email);
            loges.Add(printer);

            foreach (var eksports in loges)
            {
                eksports.export(log[0]);
                eksports.export(log[1]);
            }

        }

    }
}
