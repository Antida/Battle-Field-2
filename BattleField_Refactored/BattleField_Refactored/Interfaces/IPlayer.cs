namespace BattleField_Refactored.Interfaces
{
    interface IPlayer
    {
        string Username { get; set; }

        int FieldSize { get; set; }
    }
}
