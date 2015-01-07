using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Common;

namespace BattleField.Tests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void TestPositionIsCreatedCorrectly()
        {
            var position = new Position(3, 4);
            Assert.AreEqual(position.X, 3);
            Assert.AreEqual(position.Y, 4);
        }
    }
}
