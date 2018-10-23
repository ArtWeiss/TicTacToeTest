using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Testing
{
    public class Class1
    {
        public string[,] board;
        public string p1;
        public string p2;
        public string currentPlayer;

        public void createBoard()
        {
            board = new string[3, 3];
            p1 = "X";
            p2 = "O";
            currentPlayer = p1;
        }
        public String getCurrentPlayer()
        {
            return currentPlayer;
        }
        public String ChangePlayer()
        {
            if (currentPlayer.Equals("X"))
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
            return currentPlayer;
            //(currentPlayer.Equals("X")) ? currentPlayer = "O" : currentPlayer = "X";
        }
        public void makeMove(int x, int y, string player)
        {
            if (!spaceInUse(x, y))
            {
                board[x, y] = player;
                ChangePlayer();
            }
        }
        public bool spaceInUse(int x, int y)
        {
            if (board[x, y] == "X" || board[x, y] == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
