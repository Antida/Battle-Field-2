using BattleField_Refactored.Interfaces;
namespace BattleField_Refactored.Common
{
    public class Position : IPosition
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
