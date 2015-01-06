//-----------------------------------------------------------------------
// <copyright file="MiniMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
{
    using BattleField_Refactored.Common;

    public class MiniMine : Mine
    {
        public MiniMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { false, false, false, false, false },
                { false, true, false, true, false },
                { false, false, true, false, false },
                { false, true, false, true, false },
                { false, false, false, false, false }
            };

            this.Type = MineType.Mini;
        }
    }
}
