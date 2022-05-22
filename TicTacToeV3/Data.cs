using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV3
{
    static class Data
    {
        public static string[] board = { "a", "b", "c", "1", "2", "3" };
        public static string[] user = { "x", "o"};
        public static string checkAndOrder(string input)
        {
            int count1 = 0;
            int count2 = 0;
            string ret = "";
            string sym1 = "";
            string sym2 = "";

            if (input.Length == 2 && input.Substring(1, 1) != input.Substring(2, 1))
            {
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == input.Substring(1, 1))
                    {
                        count1++;
                        sym1 = input.Substring(1, 1);
                    }
                    if (board[i] == input.Substring(2, 1))
                    {
                        count2++;
                        sym2 = input.Substring(2, 1);
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
            int half = board.Length / 2;
            string info = " |";
            Console.Clear();
            for (int i = 0; i < half; i++)
            {
                info = info + board[i] + " | ";
            }
            Console.WriteLine(info);
        }

    }
}
