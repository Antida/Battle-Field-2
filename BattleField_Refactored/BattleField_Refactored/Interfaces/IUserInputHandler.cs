//-----------------------------------------------------------------------
// <copyright file="IUserInputHandler.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    public interface IUserInputHandler
    {
        int ReadInteger();

        string ReadText();

        IPosition ReadPosition();
    }
}
