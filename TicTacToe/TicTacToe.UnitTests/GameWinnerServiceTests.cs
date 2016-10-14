using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        private IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;
        
        [SetUp]
        public void SetupUnitTests()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3]
                  {
                      {' ', ' ', ' '}, 
                      {' ', ' ', ' '}, 
                      {' ', ' ', ' '}
                  };
        }
        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            const char expected = ' ';            
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void xPlayerWithAllSpacesInTopRowIsWinner()
        {
            const char expected = 'X';
            for (var rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                _gameBoard[0, rowIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void xPlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //[Test]
        //public void xPlayerWithAllSpacesInSecondColumnIsWinner()
        //{
        //    const char expected = 'X';
        //    for (var columnIndex = 1; columnIndex < 3; columnIndex++)
        //    {
        //        _gameBoard[columnIndex, 1] = expected;
        //    }
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected.ToString(), actual.ToString());
        //}

        //[Test]
        //public void xPlayerWithAllSpacesInThirdColumnIsWinner()
        //{
        //    const char expected = 'X';
        //    for (var columnIndex = 2; columnIndex < 3; columnIndex++)
        //    {
        //        _gameBoard[columnIndex, 2] = expected;
        //    }
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected.ToString(), actual.ToString());
        //}

        [Test]
        public void xPlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            const char expected = 'X';
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, cellIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //[Test]
        //public void xPlayerWithThreeInARowDiagonallyDownAndToLeftIsWinner()
        //{
        //    const char expected = 'X';
        //    for (var cellIndex = 0; cellIndex < 3; cellIndex++)
        //    {
        //        _gameBoard[cellIndex, 2 - cellIndex] = expected;
        //    }
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected.ToString(), actual.ToString());
        //}

        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            const char expected = 'O';
            for (var rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                _gameBoard[0, rowIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void PlayerWithAllSpacesInMiddleRowIsWinner()
        {
            const char expected = 'O';
            for (var rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                _gameBoard[0, rowIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void PlayerWithAllSpacesInBottomRowIsWinner()
        {
            const char expected = 'O';
            for (var rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                _gameBoard[0, rowIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'O';
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //[Test]
        //public void PlayerWithAllSpacesInSecondColumnIsWinner()
        //{
        //    const char expected = 'O';
        //    for (var columnIndex = 1; columnIndex < 3; columnIndex++)
        //    {
        //        _gameBoard[columnIndex, 1] = expected;
        //    }
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected.ToString(), actual.ToString());
        //}

        //[Test]
        //public void PlayerWithAllSpacesInThirdColumnIsWinner()
        //{
        //    const char expected = 'O';
        //    for (var columnIndex = 2; columnIndex < 3; columnIndex++)
        //    {
        //        _gameBoard[columnIndex, 2] = expected;
        //    }
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected.ToString(), actual.ToString());
        //}

       // [Test]
        /* public void PlayerWithThreeInARowDiagonallyDownAndToLeftIsWinner()
         { 
             const char expected = 'O';
             for (var cellIndex = 0; cellIndex < 3; cellIndex++)
             {
                 _gameBoard[cellIndex, 2 - cellIndex] = expected;
             }
             var actual = _gameWinnerService.Validate(_gameBoard);
             Assert.AreEqual(expected.ToString(), actual.ToString());
         } */

        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            const char expected = 'O';
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, cellIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}
