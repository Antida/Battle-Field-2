//-----------------------------------------------------------------------
// <copyright file="IGameField.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    public interface IGameField
    {
        /// <summary>
        /// Gets FieldSize
        /// </summary>
        int FieldSize { get; set; }

        char[,] Body { get; set; }

        char this[int row, int col] { get; set; }
    }
}
