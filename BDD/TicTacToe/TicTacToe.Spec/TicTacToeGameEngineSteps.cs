using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Game;

namespace TicTacToe.Spec
{
    [Binding]
    public class TicTacToeGameEngineSteps
    {
        private string[,] _board;
        private GameEngine _gameEngine = new GameEngine();
        private string _result;

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new String[3, 3];// { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }

        [Given(@"the tic toe board is empty")]
        public void GivenTheTicToeBoardIsEmpty()
        {
            _board = new String[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }

        [When(@"I determine an outcome")]
        public void WhenIDetermineAnOutcome()
        {
            _result = _gameEngine.GetWinner(_board);
        }

        [Then(@"the result should be no winner yet")]
        public void ThenTheResultShouldBeNoWinnerYet()
        {
            Assert.AreEqual(" ", _result);
        }

        [Given(@"I have ""(.*)"" in all the top row spot")]
        public void GivenIHaveInAllTheTopRowSpot(string p0)
        {
            _board[0, 0] = p0;
            _board[0, 1] = p0;
            _board[0, 2] = p0;
        }

        [Then(@"the reuslt should be ""(.*)"" is the winner")]
        public void ThenTheReusltShouldBeIsTheWinner(string p0)
        {
            Assert.AreEqual(p0, _result);
        }

        [Given(@"the board looks like")]
        public void GivenTheBoardLooksLike(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
