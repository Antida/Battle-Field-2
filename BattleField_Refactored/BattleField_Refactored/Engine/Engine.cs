//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Engine
{
    /// <summary>
    /// Game Engine
    /// </summary>
    public class Engine
    {
        private static Engine instance;

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
    }
}
