//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Engine
{
    using BattleField_Refactored.Interfaces;

    /// <summary>
    /// Game Engine
    /// </summary>
    public class Engine : IGameEngine
    {
        private static Engine instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="Engine" /> class from being created.
        /// </summary>
        private Engine() 
        {
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
      }
    }
}
