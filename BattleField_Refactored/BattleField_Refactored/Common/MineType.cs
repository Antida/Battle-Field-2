//-----------------------------------------------------------------------
// <copyright file="MineType.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Common
{
    public enum MineType
    {
        /// <summary>
        /// Mini mine explodes in radius of 1x1 squares
        /// </summary>
        Mini = 1,
        
        /// <summary>
        /// Double mine explodes in radius of 2x2 squares
        /// </summary>
        Double = 2,
        
        /// <summary>
        /// Average mine explodes in radius of 3x3 squares
        /// </summary>
        Average = 3,
        
        /// <summary>
        /// Big mine explodes in radius of 4x4 squares
        /// </summary>
        Big = 4,
        
        /// <summary>
        /// Huge mine explodes in radius of 5x5 squares
        /// </summary>
        Huge = 5
    }
}
