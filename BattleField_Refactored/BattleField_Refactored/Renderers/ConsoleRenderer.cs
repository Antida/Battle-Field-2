//-----------------------------------------------------------------------
// <copyright file="ConsoleRenderer.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Renderers
{
    using System;
    using BattleField_Refactored.Interfaces;
    using System.Diagnostics.CodeAnalysis;
    
    [ExcludeFromCodeCoverage]
    public class ConsoleRenderer : IRenderer
    {
        public void Render(IRenderable obj)
        {
            Console.Write(obj.RenderBody());
        }

        public void RenderText(string text)
        {
            Console.Write(text);
        }

        public void Clear()
        {
          Console.Clear();
        }
    }
}
