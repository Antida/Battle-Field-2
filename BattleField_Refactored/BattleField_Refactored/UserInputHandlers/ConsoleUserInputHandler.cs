//-----------------------------------------------------------------------
// <copyright file="ConsoleUserInputHandler.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.UserInputHandlers
{
    using System;
    using BattleField_Refactored.Interfaces;
    using BattleField_Refactored.Common;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class ConsoleUserInputHandler : IUserInputHandler
    {
        public int ReadInteger()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return -1;
            }
        }

        public string ReadText()
        {
            return Console.ReadLine();
        }

        public IPosition ReadPosition()
        {
            string[] elements = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int x = int.Parse(elements[0]);
                int y = int.Parse(elements[1]);
                return new Position(x, y);
            }
            catch (Exception)
            {
                return new Position(-1, -1);
            }

        }
    }
}
