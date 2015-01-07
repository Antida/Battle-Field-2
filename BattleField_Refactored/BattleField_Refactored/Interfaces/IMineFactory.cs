namespace BattleField_Refactored.Interfaces
{
    using BattleField_Refactored.Common;

    public interface IMineFactory
    {
        IMine CreateMine(MineType type);
    }
}
