namespace BattleField_Refactored.Engine
{
    using System;
    using BattleField_Refactored.Interfaces;
    using BattleField_Refactored.Objects;
    using System.Diagnostics.CodeAnalysis;


    public class MineController
    {
        private IMine currentMine;
        private IPosition currentPosition;
        private GameField gameField;

        public MineController(GameField gameField)
        {
            currentMine = null;
            currentPosition = null;
            this.gameField = gameField;
        }

        public GameField GameField
        {
            get
            {
                return this.gameField;
            }
        }

        [ExcludeFromCodeCoverage]
        public void SetHitPosition(IPosition position)
        {
            this.currentPosition = position;
        }

        [ExcludeFromCodeCoverage]
        public void SetMine(IMine mine)
        {
            this.currentMine = mine;
        }

        [ExcludeFromCodeCoverage]
        public int ExplodeMine()
        {
            int fieldLength = this.gameField.Body.GetLength(0) - 1;
            int offsetX = this.currentPosition.X - 2;
            int offsetY = this.currentPosition.Y - 2;
            bool[,] mineBody = this.currentMine.GetHitArea();
            int minesTakenOut = 0;
            for (int row = 0; row < mineBody.GetLength(0); row++)
            {
                for (int col = 0; col < mineBody.GetLength(1); col++)
                {
                    var rowField = row + offsetX;
                    var colField = col + offsetY;
                    if (rowField < 0 || fieldLength < rowField ||
                    colField < 0 || fieldLength < colField)
                    {
                        continue;
                    }

                    // Collision with the hit area of the mine and the current position
                    if (mineBody[row, col])
                    {
                        if ((gameField[rowField, colField] != 0) &&
                        (gameField[rowField, colField] != '*'))
                        {
                            minesTakenOut++;
                        }

                        gameField[rowField, colField] = '*';
                    }
                }
            }

            return minesTakenOut;
        }
    }
}
