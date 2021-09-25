namespace Patterns.Decorator {
    public class VideoMediaPlayer : IMediaPlayer {
        private readonly string _url;
        private int _seekTime;

        public VideoMediaPlayer(string url, int seekTime) {
            _url = url;
            _seekTime = seekTime;
        }

        public int SeekTime => _seekTime;
        public bool IsReady { get; private set; }

        public void Init() {
            //Player prepare
            IsReady = true;
        }

        public void Play() {
            //Play video from url
        }
    }
}