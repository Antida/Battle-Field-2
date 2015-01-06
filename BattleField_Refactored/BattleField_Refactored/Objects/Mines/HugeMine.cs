<<<<<<< HEAD
﻿namespace BattleField_Refactored.Objects
=======
﻿//-----------------------------------------------------------------------
// <copyright file="HugeMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b
{
    using BattleField_Refactored.Common;

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
