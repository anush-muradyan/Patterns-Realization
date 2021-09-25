namespace Patterns.Decorator {
    public class DoubleSidedVideoPlayer : IMediaPlayer {
        private readonly string _url1;
        private readonly string _url2;
        private int _seekTime;
        public int SeekTime => _seekTime;
        public bool IsReady { get; private set; }

        private IMediaPlayer player1;
        private IMediaPlayer player2;


        public DoubleSidedVideoPlayer(string url1, string url2, int seekTime) {
            _url1 = url1;
            _url2 = url2;
            _seekTime = seekTime;
        }

        public void Init() {
            player1 = new VideoMediaPlayer(_url1, _seekTime);
            player2 = new VideoMediaPlayer(_url2, _seekTime);

            player1.Init();
            player2.Init();

            IsReady = player1.IsReady && player2.IsReady;
        }

        public void Play() {
            player1.Play();
            player2.Play();
        }
    }
}