using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleField_Refactored.Engine;

namespace BattleField.Tests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void TestEngineIsCreatedCorrectly()
        {
            var engine = Engine.Instance;
            Assert.IsNotNull(engine);
            Assert.IsInstanceOfType(engine, typeof(Engine));
        }

        [TestMethod]
        public void TestEngineSingletonReturnsSameInstance()
        {
            var engineOne = Engine.Instance;
            var engineTwo = Engine.Instance;
            Assert.IsTrue(engineOne == engineTwo);
        }
    }
}
