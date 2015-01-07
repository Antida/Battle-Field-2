//-----------------------------------------------------------------------
// <copyright file="GameField.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Objects
{
    using System;
    using System.Text;
    using BattleField_Refactored.Interfaces;

    public class GameField : IGameField, IRenderable
    {
        private const int RowPadding = 4;
        private const int ColumnPadding = 2;
        private const int CellPadding = 3;
       
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

        public string RenderBody()
        {
            var fieldBody = new StringBuilder();
            fieldBody.Append(new string(' ', RowPadding));
            for (int i = 0; i < this.FieldSize; i++)
            {
                fieldBody.AppendFormat("{0}{1}", i, new string(' ', CellPadding));
            }

            fieldBody.AppendLine();
            fieldBody.Append(new string(' ', RowPadding))
                .AppendLine(new string('-', this.FieldSize * CellPadding));

            for (int i = 0; i < this.FieldSize; i++)
            {
                fieldBody.AppendFormat("{0}{1}| {2}", i, new string(' ', ColumnPadding), this.RenderRow(i));
            }

            return fieldBody.ToString();
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

        private string RenderRow(int rowNumber)
        {
            var row = new StringBuilder();
            for (int col = 0; col < this.FieldSize; col++)
            {
                row.AppendFormat("{0}{1}", this[rowNumber, col], new string(' ', ColumnPadding))
                    .Append("|");
            }

            return row.ToString();
        }
    }
}
