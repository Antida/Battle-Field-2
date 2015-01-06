namespace BattleField_Refactored.Interfaces
{
    public interface IGameField
    {
        int FieldSize { get; set; }

<<<<<<< HEAD
        char[,] Body { get; set; }
=======
        char[,] Field { get; set; }
>>>>>>> a0bb761a918eb40d0099ea554927dd9b0feef89b

        char this[int row, int col] { get; set; }
    }
}
