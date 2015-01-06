//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Engine
{
    /// <summary>
    /// <para></para>
    /// </summary>
    public class Engine
    {
        private static Engine instance;

        private Engine() 
        {
        }

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
