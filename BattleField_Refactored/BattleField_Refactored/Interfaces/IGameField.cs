namespace BattleField_Refactored.Interfaces
{
    public interface IGameField
    {
        int FieldSize { get; set; }

        char[,] Body { get; set; }

        char this[int row, int col] { get; set; }
    }
}
