//-----------------------------------------------------------------------
// <copyright file="IMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    using BattleField_Refactored.Common;

    public interface IMine : IExplosible
    {
        bool[,] Body { get; set; }

        MineType Type { get; set; }
    }
}
