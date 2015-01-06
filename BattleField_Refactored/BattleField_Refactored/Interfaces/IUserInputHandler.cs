namespace BattleField_Refactored.Interfaces
{
    public interface IUserInputHandler
    {
        int ReadInteger();

        string ReadText();

        IPosition ReadPosition();
    }
}
