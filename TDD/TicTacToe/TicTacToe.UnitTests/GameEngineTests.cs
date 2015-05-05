using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe.Game;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    class GameEngineTests
    {
        private string[,] _board;
        private GameEngine _gameEngine;

        [SetUp]
        public void SetUpTest()
        {
            _board = new String[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            _gameEngine = new GameEngine();
            
        }

        [Test]
        public void WhenIHaveAnEmptyBoardGameIsNotOverNoWinner()
        {
            var expectedResult = " ";

            var result = _gameEngine.GetWinner(_board);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenIHaveThreeXInTheTopRowThenXShouldWin()
        {
            _board[0, 0] = "X";
            _board[0, 1] = "X";
            _board[0, 2] = "X";

            var expectedResult = "X";

            var result = _gameEngine.GetWinner(_board);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
