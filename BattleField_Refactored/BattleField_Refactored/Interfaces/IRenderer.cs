namespace BattleField_Refactored.Interfaces
{
    public interface IRenderer
    {
        void Render(IRenderable obj);

        void RenderText(string text);

        void Clear();
    }
}
