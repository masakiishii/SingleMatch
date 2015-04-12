using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace srm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            BichromeBoard bb = new BichromeBoard();
            string[] board1 = new string[]{"W?W", "??B", "???"};
            string[] board2 = new string[]{"W??W"};
            string[] board3 = new string[]{"??"};
            string[] board4 = new string[]{"W???",
                                          "??B?",
                                          "W???",
                                          "???W"};
            string[] board5 = new string[]{"W???",
                                          "??B?",
                                          "W???",
                                          "?B?W"};
            string[] board6 = new string[]{"B"};
            Console.WriteLine(bb.ableToDraw(board1));
            Console.WriteLine(bb.ableToDraw(board2));
            Console.WriteLine(bb.ableToDraw(board3));
            Console.WriteLine(bb.ableToDraw(board4));
            Console.WriteLine(bb.ableToDraw(board5));
            Console.WriteLine(bb.ableToDraw(board6));
            Console.ReadLine();
        }
    }
    public class BichromeBoard
    {
        public string ableToDraw(string[] board)
        {
            // Debugger.Break();
            int even_B = 0, even_W = 0, odd_B = 0, odd_W = 0;
            for(int i = 0; i < board.Length; i++) {
                for(int j = 0; j < board[i].Length; j++) {
                    if(board[i][j].Equals('B')) {
                        if((i + j) % 2 == 0) {
                            even_B += 1;
                        }
                        else {
                            odd_B += 1;
                        }
                    }
                    if(board[i][j].Equals('W')) {
                        if((i + j) % 2 == 0) {
                            even_W += 1;
                        }
                        else {
                            odd_W += 1;
                        }
                    }
                }
            }
            if(odd_W == even_B || odd_B == even_W) {
                return "Possible";
            }
            return "Impossible";
        }
    }
}
