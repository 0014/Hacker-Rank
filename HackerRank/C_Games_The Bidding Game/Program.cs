using System;

namespace C_Games_The_Bidding_Game
{
    class Program
    {
        static int calculate_bid(int player, int pos, int[] first_moves, int[] second_moves)
        {

            int first_balance = 100;
            int second_balance = 100;

            if (first_moves.Length != 0)
            {
                first_balance = calculate_balance(1, first_moves, second_moves);
                second_balance = calculate_balance(2, first_moves, second_moves);
            }

            if (second_balance == 0)
            {
                if (first_balance > 0) return 1;
                else return 0;
            }

            else if (first_balance < 15) return first_balance;

            return 15;
        }

        static int calculate_balance(int player, int[] first_moves, int[] second_moves)
        {
            int initial_balance = 100;
            int sum = 0;
            Boolean toggle = false;

            switch (player)
            {
                case (1):
                    for (int i = 0; i < first_moves.Length; i++)
                    {
                        if (first_moves[i] < second_moves[i]) continue;

                        else if (first_moves[i] == second_moves[i])
                        {
                            if (!toggle)
                            {
                                sum += first_moves[i];
                                toggle = true;
                                continue;
                            }
                            else
                            {
                                toggle = false;
                                continue;
                            }
                        }

                        else sum += first_moves[i];
                    }

                    break;

                case (2):
                    for (int i = 0; i < second_moves.Length; i++)
                    {
                        if (second_moves[i] < first_moves[i]) continue;

                        else if (first_moves[i] == second_moves[i])
                        {
                            if (!toggle)
                            {
                                toggle = true;
                                continue;
                            }
                            else
                            {
                                sum += second_moves[i];
                                toggle = false;
                                continue;
                            }
                        }
                        else sum += second_moves[i];
                    }

                    break;
            }

            return initial_balance - sum;
        }

        static void Main(String[] args)
        {
            int player = int.Parse(Console.ReadLine());
            int scotch_pos = int.Parse(Console.ReadLine());
            int bid = 0;                                 //Amount bid by the players
            String first_move = Console.ReadLine();     //Previous moves made by the first player
            String second_move = Console.ReadLine();     //Previous moves made by the second player
            String[] move_1 = first_move.Split(' ');
            String[] move_2 = second_move.Split(' ');
            int[] first_moves = new int[200];
            int[] second_moves = new int[200];
            if (String.Compare(first_move, "") != 0)
            {
                for (int i = 0; i < move_1.Length; i++)
                {
                    first_moves[i] = Convert.ToInt32(move_1[i]);
                    second_moves[i] = Convert.ToInt32(move_2[i]);
                }
            }
            bid = calculate_bid(player, scotch_pos, first_moves, second_moves);
            Console.Write(bid);
        }
    }
}
