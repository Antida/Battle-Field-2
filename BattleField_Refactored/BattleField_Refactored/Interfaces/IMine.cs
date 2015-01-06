<<<<<<< HEAD
﻿using BattleField_Refactored.Common;
=======
﻿//-----------------------------------------------------------------------
// <copyright file="IMine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
using BattleField_Refactored.Common;

>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b
namespace BattleField_Refactored.Interfaces
{
    public interface IMine : IExplosible
    {
        bool[,] Body { get; set; }

        MineType Type { get; set; }
    }
}
