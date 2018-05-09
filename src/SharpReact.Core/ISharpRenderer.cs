namespace SharpReact.Core
{
    public interface ISharpRenderer
    {
        void StateChanged(NewState newState);
        void Redraw();
    }
}
