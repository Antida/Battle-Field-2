//-----------------------------------------------------------------------
// <copyright file="DoubleMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects.Mines
{
    using BattleField_Refactored.Common;

    /// <summary>
    /// Mine with a range of 2
    /// </summary>
    public class DoubleMine : Mine
    {
        public DoubleMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { false, false, false, false, false },
                { false, true, true, true, false },
                { false, true, true, true, false },
                { false, true, true, true, false },
                { false, false, false, false, false }
            };

            this.Type = MineType.Double;
        }
    }
}
