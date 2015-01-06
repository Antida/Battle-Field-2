<<<<<<< HEAD
﻿namespace BattleField_Refactored.Objects
=======
﻿//-----------------------------------------------------------------------
// <copyright file="DoubleMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b
{
    using BattleField_Refactored.Common;

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
