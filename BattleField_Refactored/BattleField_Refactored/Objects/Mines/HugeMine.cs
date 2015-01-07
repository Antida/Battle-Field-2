//-----------------------------------------------------------------------
// <copyright file="HugeMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects.Mines
{
    using BattleField_Refactored.Common;

    /// <summary>
    /// Mine with a range of 5
    /// </summary>
    public class HugeMine : Mine
    {
        public HugeMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true }
            };

            this.Type = MineType.Huge;
        }
    }
}
