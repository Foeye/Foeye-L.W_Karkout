using Framewrok.Core;

namespace Framewrok.System
{
    public interface ISystem
    {
        void Initialize(GameCore core);
        void StartPlay();
        void Update();
    }
}