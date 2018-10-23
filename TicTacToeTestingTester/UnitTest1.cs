using TicTacToe_Testing;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToe_Testing.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        //Assert the board has 9 active fields
        public void createBoardTest()
        {
            int expected = 9;
            var test = new Class1();

            test.createBoard();
            int actual = test.board.Length;

            Assert.AreEqual(expected, actual);
        }

        //Assert the current player is X
        [TestMethod()]
        public void currentPlayerTest()
        {
            string expected = "X";
            var test = new Class1();

            test.createBoard();
            string actual = test.getCurrentPlayer();

            Assert.AreEqual(expected, actual);

            test.ChangePlayer();
            string expected2 = "O";
            string actual2 = test.getCurrentPlayer();

            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void makeMoveTest()
        {
            string expected = "X";
            string expected2 = "O";
            var test = new Class1();

            test.createBoard();
            test.makeMove(1, 1, test.getCurrentPlayer());
            string actual = test.board[1, 1];

            Assert.AreEqual(expected, actual);


            test.makeMove(2, 2, test.getCurrentPlayer());
            string actual2 = test.board[2, 2];

            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void spaceInUseTest()
        {
            var test = new Class1();
            bool expected = false;

            test.createBoard();
            bool actual = test.spaceInUse(1, 1);
            test.makeMove(1, 1, "X");


            Assert.AreEqual(expected, actual);
        }
    }
}
