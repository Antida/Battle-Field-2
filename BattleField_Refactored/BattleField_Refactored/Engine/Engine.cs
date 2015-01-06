namespace BattleField_Refactored.Engine
{
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
