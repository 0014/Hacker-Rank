using System;
using System.Collections.Generic;
using System.IO;

namespace Game1_LightsOut
{
    class Program
    {
        static bool nextMove(int player, String[] board)
        {
            bool cellFound = false;
            int r = -1; int c = -1;

            for (int i = 0; i < 8; i++)
            {
                if (cellFound) break;

                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == '1')
                    {
                        cellFound = true;
                        r = i;
                        c = j;
                        break;
                    }
                }
            }
            if (!cellFound) 
                return true;
            else
            {
                Console.WriteLine(r + " " + c);
                return false;
            }
            

        }
        static void Main(String[] args)
        {
            int player;
            bool gameOver = false;
            
            //If player is 1, I'm the first player.
            //If player is 2, I'm the second player.
            player = int.Parse(Console.ReadLine());

            //Read the board now. The board is a 8x8 array filled with 1 or 0.
            String[] board = new String[8];
            for (int i = 0; i < 8; i++)
            {
                board[i] = Console.ReadLine();
            }
                while (!gameOver)
                    gameOver = nextMove(player, board);
            }
        }
    
}
