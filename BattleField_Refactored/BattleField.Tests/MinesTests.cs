using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Objects.Mines;
using BattleField_Refactored.Common;

namespace BattleField.Tests
{
    [TestClass]
    public class MineTests
    {
        [TestMethod]
        public void TestMiniMineCreatedCorrectly()
        {
            var mine = new MiniMine();
            Assert.AreEqual(mine.Type, MineType.Mini);
            Assert.AreEqual((int)mine.Type, 1);
        }

        [TestMethod]
        public void TestDoubleMineCreatedCorrectly()
        {
            var mine = new DoubleMine();
            Assert.AreEqual(mine.Type, MineType.Double);
            Assert.AreEqual((int)mine.Type, 2);
        }

        [TestMethod]
        public void TestAverageMineCreatedCorrectly()
        {
            var mine = new AverageMine();
            Assert.AreEqual(mine.Type, MineType.Average);
            Assert.AreEqual((int)mine.Type, 3);
        }

        [TestMethod]
        public void TestBigMineCreatedCorrectly()
        {
            var mine = new BigMine();
            Assert.AreEqual(mine.Type, MineType.Big);
            Assert.AreEqual((int)mine.Type, 4);
        }

        [TestMethod]
        public void TestHugeMineCreatedCorrectly()
        {
            var mine = new HugeMine();
            Assert.AreEqual(mine.Type, MineType.Huge);
            Assert.AreEqual((int)mine.Type, 5);
        }
    }
}
