using WMPLib;

namespace SoundCard
{
    class WMPMethod : IPlayingMethod, IPausable
    {
        private WindowsMediaPlayer _player = new WindowsMediaPlayer();
        private double _currentPosition;

        public void Play(string filename)
        {
            _player.URL = filename;
            _player.controls.play();
        }

        public void Stop()
        {
            _player.controls.stop();
        }

        public void Pause()
        {
            _currentPosition = _player.controls.currentPosition;
            _player.controls.pause();
        }

        public void Resume()
        {
            _player.controls.currentPosition = _currentPosition;
            _player.controls.play();
        }
    }
}
