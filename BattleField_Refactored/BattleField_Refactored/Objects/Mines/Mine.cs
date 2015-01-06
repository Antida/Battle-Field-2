<<<<<<< HEAD
﻿namespace BattleField_Refactored.Objects
=======
﻿//-----------------------------------------------------------------------
// <copyright file="Mine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b
{
    using System;
    using BattleField_Refactored.Common;
    using BattleField_Refactored.Interfaces;

    public abstract class Mine : IMine
    {
        public Mine()
        {
            this.Create();
        }

        public bool[,] Body { get; set; }

        public MineType Type { get; set; }

        public abstract void Create();

        public bool[,] GetHitArea()
        {
            if (this.Body.GetLength(0) != Constants.MineGridSize || this.Body.GetLength(1) != Constants.MineGridSize)
            {
                throw new ArgumentException("The mine hit area must be a 5x5 boolean matrix.");
            }

            return this.Body;
        }
    }
}
