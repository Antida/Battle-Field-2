namespace BattleField_Refactored.Engine
{
    using System;
    using BattleField_Refactored.Common;
    using BattleField_Refactored.Interfaces;
    using BattleField_Refactored.Objects;

    public class MineFactory : IMineFactory
    {
        public IMine CreateMine(MineType type)
        {
            switch (type)
            {
                case MineType.Mini:
                    return new MiniMine();
                case MineType.Double:
                    return new DoubleMine();
                case MineType.Average:
                    return new AverageMine();
                case MineType.Big:
                    return new BigMine();
                case MineType.Huge:
                    return new HugeMine();
                default:
                    throw new InvalidOperationException("The mine type specified is invalid.");
            }
        }
    }
}
