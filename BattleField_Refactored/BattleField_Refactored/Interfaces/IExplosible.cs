//-----------------------------------------------------------------------
// <copyright file="IExplosible.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    public interface IExplosible
    {
        bool[,] GetHitArea();
    }
}
