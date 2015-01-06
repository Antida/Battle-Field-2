<<<<<<< HEAD
﻿namespace BattleField_Refactored.Objects
=======
﻿//-----------------------------------------------------------------------
// <copyright file="AverageMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b
{
    using BattleField_Refactored.Common;

    public class AverageMine : Mine
    {
        public AverageMine()
            : base()
        {
        }

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
