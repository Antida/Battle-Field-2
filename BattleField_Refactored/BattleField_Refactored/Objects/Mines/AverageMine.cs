//-----------------------------------------------------------------------
// <copyright file="AverageMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects.Mines
{
    using BattleField_Refactored.Common;

    /// <summary>
    /// Mine with range of 4
    /// </summary>
    public class AverageMine : Mine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AverageMine" /> class.
        /// </summary>
        public AverageMine()
            : base()
        {
        }

        /// <summary>
        /// Create mine with range of 4
        /// </summary>
        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { false, false, true, false, false },
                { false, true, true, true, false },
                { true, true, true, true, true },
                { false, true, true, true, false },
                { false, false, true, false, false }
            };

            this.Type = MineType.Average;
        }
    }
}
