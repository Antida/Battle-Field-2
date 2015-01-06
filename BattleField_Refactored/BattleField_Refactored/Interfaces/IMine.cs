//-----------------------------------------------------------------------
// <copyright file="IMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
using BattleField_Refactored.Common;

namespace BattleField_Refactored.Interfaces
{
    public interface IMine : IExplosible
    {
        bool[,] Body { get; set; }

        MineType Type { get; set; }
    }
}
