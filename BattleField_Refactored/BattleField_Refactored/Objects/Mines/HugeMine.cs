namespace BattleField_Refactored.Objects
{
    using BattleField_Refactored.Common;

    public class HugeMine : Mine
    {
        public HugeMine()
            : base()
        {
        }

        public override void Create()
        {
            this.Body = new bool[5, 5] 
            {
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true },
                { true, true, true, true, true }
            };

            this.Type = MineType.Huge;
        }
    }
}
