namespace BattleField_Refactored.Objects
{
    using System;
    using BattleField_Refactored.Interfaces;

    public class GameField : IGameField, IRenderable
    {
        public GameField(int size)
        {
            this.FieldSize = size;
            this.Body = new char[size, size];
        }

        public int FieldSize { get; set; }

        public char[,] Body { get; set; }

        public char this[int row, int col]
        {
            get
            {
                this.ValidateIndex(row, col);
                return this.Body[row, col];
            }
            set
            {
                this.ValidateIndex(row, col);
                this.Body[row, col] = value;
            }
        }

        private void ValidateIndex(int row, int col)
        {
            if (row < 0 || row > this.FieldSize)
            {
                throw new IndexOutOfRangeException("The row must be between 0 and " + this.FieldSize + ".");
            }

            if (col < 0 || col > this.FieldSize)
            {
                throw new IndexOutOfRangeException("The column must be between 0 and " + this.FieldSize + ".");
            }
        }
    }
}
