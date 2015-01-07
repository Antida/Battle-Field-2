//-----------------------------------------------------------------------
// <copyright file="BattleField.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField
{
    using System;
    using BattleField_Refactored.Engine;
    using System.Diagnostics.CodeAnalysis;
    
    [ExcludeFromCodeCoverage]
    public class BattleField
    {
        public static void Main()
        {
            var engine = Engine.Instance;
            engine.Run();
        }
    }
}