//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Engine
{
    using System;
    using BattleField_Refactored.Interfaces;
    using BattleField_Refactored.Renderers;
    using BattleField_Refactored.UserInputHandlers;
    using BattleField_Refactored.Common;
    using BattleField_Refactored.Objects;

    /// <summary>
    /// Game Engine
    /// </summary>
    public class Engine : IGameEngine
    {
        private static Engine instance;

        private static readonly Random generator = new Random();
        private IUserInputHandler input;
        private IRenderer output;
        private GameField gameField;
        private IMineFactory mineFactory = new MineFactory();
        private MineController mineController;
        private int score = 0;
        private IPosition lastPosition;

        /// <summary>
        /// Prevents a default instance of the <see cref="Engine" /> class from being created.
        /// </summary>
        private Engine()
        {
            this.input = new ConsoleUserInputHandler();
            this.output = new ConsoleRenderer();
            this.mineController = new MineController(this.gameField);
        }

        /// <summary>
        /// Gets the only instance of the singleton Engine class.
        /// </summary>
        public static Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }

                return instance;
            }
        }

        public void Run()
        {
            this.output.RenderText("Welcome to \"Battle Field\" game.\nEnter battle field size: n = ");
            int size = this.input.ReadInteger();

            while (size == -1 || size < Constants.MinFieldSize || size > Constants.MaxFieldSize)
            {
                this.output.RenderText("The field size is invalid. It must be a number between 1 and 10.");
                size = this.input.ReadInteger();
            }

            this.gameField = new GameField(size);
            int mines = this.PlaceMines(size);
            while (mines > 0)
            {
                this.output.Clear();
                // ShowLastHit();
                this.output.Render(gameField);
                do
                {
                    this.output.RenderText("Please enter coordinates: ");
                    this.lastPosition = this.input.ReadPosition();
                }
                while (!IsValidPosition());
                score++;
                bool isMineHit = IsMineHit();
                if (isMineHit)
                {
                    string mineHitOnField = gameField[this.lastPosition.X, this.lastPosition.Y].ToString();
                    int mineHit = int.Parse(mineHitOnField);
                    var currentMine = mineFactory.CreateMine((MineType)mineHit);
                    mineController.SetMine(currentMine);
                    mineController.SetHitPosition(this.lastPosition);

                    // Explode mine
                    int minesTakenOut = mineController.ExplodeMine();
                    mines -= minesTakenOut;
                }
            }
        }

        private int PlaceMines(int fieldSize)
        {
            int mines = generator.Next(15 * fieldSize * fieldSize / 100, 30 * fieldSize * fieldSize / 100 + 1);
            for (int i = 0; i < mines; i++)
            {
                int x = generator.Next(0, fieldSize);
                int y = generator.Next(0, fieldSize);
                while (this.gameField.Body[x, y] != 0)
                {
                    x = generator.Next(0, fieldSize);
                    y = generator.Next(0, fieldSize);
                }

                this.gameField.Body[x, y] = generator.Next(1, 6).ToString()[0];
            }

            return mines;
        }

      private bool IsMineHit()
      {

      }

      private bool IsValidPosition()
        {
            if ((0 <= this.lastPosition.X && this.lastPosition.X < this.gameField.FieldSize) &&
                (0 <= this.lastPosition.Y && this.lastPosition.Y < this.gameField.FieldSize))
            {
                return true;
            }

            return false;
        }
    }
}
