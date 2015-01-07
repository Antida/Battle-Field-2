//-----------------------------------------------------------------------
// <copyright file="IPlayer.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    public interface IPlayer
    {
        string Username { get; set; }

        int FieldSize { get; set; }
    }
}
