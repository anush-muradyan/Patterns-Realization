namespace Patterns.Decorator {
    public interface IMediaPlayer {
        int SeekTime { get; }
        bool IsReady { get; }
        void Init();
        void Play();
    }
}