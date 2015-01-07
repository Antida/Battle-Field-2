using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Engine;
using BattleField_Refactored.Common;

namespace BattleField.Tests
{
    [TestClass]
    public class MineFactoryTests
    {
        [TestMethod]
        public void TestMiniMineCreatedCorrectly()
        {
            var factory = new MineFactory();
            var mine = factory.CreateMine(MineType.Mini);
            Assert.AreEqual(mine.Type, MineType.Mini);
        }

        [TestMethod]
        public void TestDoubleMineCreatedCorrectly()
        {
            var factory = new MineFactory();
            var mine = factory.CreateMine(MineType.Double);
            Assert.AreEqual(mine.Type, MineType.Double);
        }

        [TestMethod]
        public void TestAverageMineCreatedCorrectly()
        {
            var factory = new MineFactory();
            var mine = factory.CreateMine(MineType.Average);
            Assert.AreEqual(mine.Type, MineType.Average);
        }

        [TestMethod]
        public void TestBigMineCreatedCorrectly()
        {
            var factory = new MineFactory();
            var mine = factory.CreateMine(MineType.Big);
            Assert.AreEqual(mine.Type, MineType.Big);
        }

        [TestMethod]
        public void TestHugeMineCreatedCorrectly()
        {
            var factory = new MineFactory();
            var mine = factory.CreateMine(MineType.Huge);
            Assert.AreEqual(mine.Type, MineType.Huge);
        }
    }
}
