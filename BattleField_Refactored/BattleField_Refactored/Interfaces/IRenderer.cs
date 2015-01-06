//-----------------------------------------------------------------------
// <copyright file="IRenderer.cs" company="Team Antida 2014">
//        It's OpenSource.
// </copyright>
//-----------------------------------------------------------------------
namespace BattleField_Refactored.Interfaces
{
    public interface IRenderer
    {
        void Render(IRenderable obj);

        void RenderText(string text);

        void Clear();
    }
}
