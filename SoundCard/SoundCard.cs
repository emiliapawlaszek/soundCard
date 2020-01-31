using System;

namespace SoundCard
{
    class SoundCard
    {
        private IPlayingMethod _playingMethod;
        private IRecordingMethod _recordingMethod;

        public String Filename
        {
            get; set;
        }

        public IntPtr Parent
        {
            get; set;
        }

        public String PlayingMethod
        {
            set
            {
                if (_playingMethod != null)
                    _playingMethod.Stop();

                switch (value)
                {
                    case "PlaySound":
                        _playingMethod = new PlaySoundMethod();
                        break;
                    case "Windows Media Player":
                        _playingMethod = new WMPMethod();
                        break;
                    case "MCI":
                        _playingMethod = new MCIPlayingMethod();
                        break;
                    case "DirectSound":
                        _playingMethod = new DirectSoundPlayingMethod(Parent);
                        break;
                    default:
                        _playingMethod = null;
                        break;
                }
            }
        }

        public String RecordingMethod
        {
            set
            {
                switch (value)
                {
                    case "MCI":
                        _recordingMethod = new MCIRecordingMethod();
                        break;
                    default:
                        _recordingMethod = null;
                        break;
                }
            }
        }

        public static bool IsPausable(String methodname)
        {
            switch (methodname)
            {
                case "PlaySound":
                    return false;
                case "Windows Media Player":
                    return true;
                case "MCI":
                    return true;
                case "DirectSound":
                    return true;
                default:
                    return false;
            }
        }

        public void Play()
        {
            _playingMethod.Play(Filename);

        }

        public void Stop()
        {
            _playingMethod.Stop();
        }

        public void Pause()
        { 
            if (_playingMethod is IPausable)
            {
                var pausableMethod = (IPausable)_playingMethod;
                pausableMethod.Pause();
            }

        }

        public void Resume()
        {
            if (_playingMethod is IPausable)
            {
                var pausableMethod = (IPausable)_playingMethod;
                pausableMethod.Resume();
            }
        }

        public void Record()
        {
            _recordingMethod.Record();
        }

        public void SaveRecordedFile(String filename)
        {
            _recordingMethod.Save(filename);
        }
    }
}
