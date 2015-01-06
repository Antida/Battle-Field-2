namespace BattleField_Refactored.Objects
{
    using BattleField_Refactored.Common;

    public class DoubleMine : Mine
    {
        public DoubleMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { false, false, false, false, false },
                { false, true, true, true, false },
                { false, true, true, true, false },
                { false, true, true, true, false },
                { false, false, false, false, false }
            };

            this.Type = MineType.Double;
        }
    }
}
