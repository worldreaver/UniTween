namespace Worldreaver.UniTween
{
    public interface IScheduler
    {
        float Now { get; }
        bool Paused { get; }
    }
}