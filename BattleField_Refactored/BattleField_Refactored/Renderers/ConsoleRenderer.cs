//-----------------------------------------------------------------------
// <copyright file="ConsoleRenderer.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Renderers
{
    using System;
    using BattleField_Refactored.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public void Render(IRenderable obj)
        {
            Console.WriteLine(obj.RenderBody());
        }

        public void RenderText(string text)
        {
            Console.WriteLine(text);
        }

        public void Clear()
        {
          Console.Clear();
        }
    }
}
