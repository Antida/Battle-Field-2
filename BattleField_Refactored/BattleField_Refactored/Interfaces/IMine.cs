using BattleField_Refactored.Common;
namespace BattleField_Refactored.Interfaces
{
    public interface IMine : IExplosible
    {
        bool[,] Body { get; set; }

        MineType Type { get; set; }
    }
}
