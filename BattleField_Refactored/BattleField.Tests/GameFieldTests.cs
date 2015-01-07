using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Objects;

namespace BattleField.Tests
{
    [TestClass]
    public class GameFieldTests
    {
        [TestMethod]
        public void TestGameField()
        {
            var gameField = new GameField(3);
            Assert.AreEqual(gameField.FieldSize, 3);
        }

        [TestMethod]
        public void TestGameFieldIndexerGet()
        {
            var gameField = new GameField(3);
            Assert.IsNotNull(gameField[2, 2]);
            Assert.IsNotNull(gameField[0, 0]);
        }

        [TestMethod]
        public void TestGameFieldIndexerSet()
        {
            var gameField = new GameField(3);
            gameField[2, 1] = 'a';
            Assert.IsNotNull(gameField[2, 1]);
            Assert.AreEqual(gameField[2, 1], 'a');
        }
    }
}
