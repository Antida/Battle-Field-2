using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Engine;
using BattleField_Refactored.Objects;

namespace BattleField.Tests
{
    [TestClass]
    public class MineControllerTests
    {
        [TestMethod]
        public void TestMineControllerIsCreatedCorrectly()
        {
            var mineController = new MineController(new GameField(5));
            Assert.IsNotNull(mineController);
            Assert.IsInstanceOfType(mineController, typeof(MineController));
        }

        [TestMethod]
        public void TestMineControllerSetsGameFieldCorrectly()
        {
            var gameField = new GameField(5);
            var mineController = new MineController(gameField);
            Assert.IsNotNull(mineController.GameField);
            Assert.IsTrue(mineController.GameField == gameField);
        }
    }
}
