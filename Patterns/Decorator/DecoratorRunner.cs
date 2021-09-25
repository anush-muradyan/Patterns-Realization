using System;

namespace Patterns.Decorator {
    public class DecoratorRunner : AbstractRunner {
        public override void Run() {
            IMediaPlayer mediaPlayer = new VideoMediaPlayer("url", 2);
            mediaPlayer.Init();
            mediaPlayer.Play();
            
            mediaPlayer = new DoubleSidedVideoPlayer("url1", "url2", 2);
            mediaPlayer.Init();
            mediaPlayer.Play();
        }
    }
}