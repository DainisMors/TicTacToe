using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV3
{
    public static class Data
    {
        public static string[] board = { "a", "b", "c", "1", "2", "3" };
        
        public static string CheckAndOrder(string input)
        {
            int count1 = 0;
            int count2 = 0;
            string ret = "";
            string sym1 = "";
            string sym2 = "";
            string sym01 = input.Substring(0, 1);
            string sym02 = input.Substring(1, 1);

            if (input.Length == 2 && sym01 != sym02)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == sym01)
                    {
                        if (i >= board.Length/2)
                        {
                            sym2 = sym01;
                            count2++;
                        }
                        else
                        {
                            sym1 = sym01;
                            count1++;
                        }
                    }
                    if (board[i] == sym02)
                    {
                        if (i >= board.Length / 2)
                        {
                            sym2 = sym02;
                            count2++;
                        }
                        else
                        {
                            sym1 = sym02;
                            count1++;
                        }
                    }
                }
                if (count1 == 1 && count2 == 1)
                {
                    ret = sym1 + sym2;
                }
            }
            return ret;
        }
        public static void DisplayBoard(string[] input)
        {
            string displayInfo = "Jāievada koordinātes, piemēram 1a vai b3... utt, pēc tam Enter. Ievadot X spēle beidzas.";
            int half = board.Length / 2;
            string info = "  | ";
            int count = 0;
            Console.Clear();
            Console.WriteLine("Tic Tac Toe, Version DM :)");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < half; i++)
            {
                info = info + board[i] + " | ";
            }
            Console.WriteLine(info);

            info = "----";
            for (int i = 0; i < half; i++)
            {
                info = info + "----";
            }
            Console.WriteLine(info);

            for (int i = half; i < board.Length; i++)
            {
                info = board[i] + " | ";
                for (int i2 = 0; i2 < half; i2++)
                {
                    info = info + input[count] + " | ";
                    count++;
                }
                Console.WriteLine(info);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(displayInfo);

        }
        public static string[] FillDisplayInfo(string[] input, string user, string code)
        {
            int half = board.Length / 2;
            int counter = 0;

            for (int i = 0; i < half; i++)
            {
                if (code.Substring(0, 1) == board[i])
                {
                    //counter = half * i;
                    for (int i2 = half; i2 < board.Length; i2++)
                    {
                        if (code.Substring(1, 1) == board[i2])
                        {
                            if (input[counter] == " ")
                            {
                                input[counter] = user;
                                Data.DisplayBoard(input);
                            }
                            else
                            {
                                Console.WriteLine("Lūdzu uzmanīgāk! Lauciņš " + code + " ir jau izmantots!" );
                                Console.WriteLine("Tavs gājiens tiek izlaists!");
                                Console.WriteLine("");
                            }
                            break;
                        }
                        counter = counter + half;
                    }
                }
                counter++;
            }
/*
Console.WriteLine("code:" + code + ", user:" + user);
Console.WriteLine(input[0] + input[1] + input[2]);
Console.WriteLine(input[3] + input[4] + input[5]);
Console.WriteLine(input[6] + input[7] + input[8]);
*/
            return input;
        }

    }
}
