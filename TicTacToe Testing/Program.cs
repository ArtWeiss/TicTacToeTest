using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TicTacToe_Testing
{
    class Program
    {
        static char[] boardSquares = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int winFlag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("p1: X   p2: O");
                Console.Write("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("p2 turn");
                }
                else
                {
                    Console.WriteLine("p1 turn");
                }
                Console.WriteLine("\n");
                CreateBoard();
                choice = int.Parse(Console.ReadLine());

                if (!SpaceInUse())
                {
                    if (player % 2 == 0)
                    {
                        boardSquares[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        boardSquares[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("The row {0} is already marked with {1}", choice, boardSquares[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Wait, board is loading again.....");
                    Thread.Sleep(2000);
                }

                winFlag = CheckWin();

            } while (winFlag == 0);

            Console.Clear();
            CreateBoard();

            if (winFlag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        public static void CreateBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardSquares[1], boardSquares[2], boardSquares[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardSquares[4], boardSquares[5], boardSquares[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardSquares[7], boardSquares[8], boardSquares[9]);
            Console.WriteLine("     |     |      ");
        }

        public static bool SpaceInUse()
        {
            if (boardSquares[choice] != 'X' && boardSquares[choice] != 'O')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static int CheckWin()
        {
            //Winning Condition For First Row   
            if (boardSquares[1] == boardSquares[2] && boardSquares[2] == boardSquares[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (boardSquares[4] == boardSquares[5] && boardSquares[5] == boardSquares[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (boardSquares[6] == boardSquares[7] && boardSquares[7] == boardSquares[8])
            {
                return 1;
            }
            //Winning Condition For First Column
            else if (boardSquares[1] == boardSquares[4] && boardSquares[4] == boardSquares[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (boardSquares[2] == boardSquares[5] && boardSquares[5] == boardSquares[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (boardSquares[3] == boardSquares[6] && boardSquares[6] == boardSquares[9])
            {
                return 1;
            }
            else if (boardSquares[1] == boardSquares[5] && boardSquares[5] == boardSquares[9])
            {
                return 1;
            }
            else if (boardSquares[3] == boardSquares[5] && boardSquares[5] == boardSquares[7])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then any player has won the match  
            else if (boardSquares[1] != '1' && boardSquares[2] != '2' && boardSquares[3] != '3' && boardSquares[4] != '4' && boardSquares[5] != '5' && boardSquares[6] != '6' && boardSquares[7] != '7' && boardSquares[8] != '8' && boardSquares[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
