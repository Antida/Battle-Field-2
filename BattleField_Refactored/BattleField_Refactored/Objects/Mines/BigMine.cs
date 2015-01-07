//-----------------------------------------------------------------------
// <copyright file="BigMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
{
    using BattleField_Refactored.Common;

    /// <summary>
    /// Mine with a range of 4
    /// </summary>
    public class BigMine : Mine
    {
        public BigMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { false, true, true, true, false },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { false, true, true, true, false }
            };

            this.Type = MineType.Big;
        }
    }
}
