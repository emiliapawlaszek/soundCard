using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SoundCard
{
    class MCIPlayingMethod : IPlayingMethod, IPausable
    {
        private String _filename;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command,
            StringBuilder retstring, int ReturnLength, IntPtr callback);


        public void Play(string filename)
        {
            _filename = filename;

            String commandOpen = "open \"" + filename + "\" alias MediaFile";
            mciSendString(commandOpen, null, 0, IntPtr.Zero);

            String commandPlay = "play Mediafile";
            mciSendString(commandPlay, null, 0, IntPtr.Zero);
        }

        public void Stop()
        {
            String commandStop = "stop Mediafile";
            mciSendString(commandStop, null, 0, IntPtr.Zero);

            String commandClose = "close Mediafile";
            mciSendString(commandClose, null, 0, IntPtr.Zero);
        }

        public void Pause()
        {
            String commandPause = "pause Mediafile";
            mciSendString(commandPause, null, 0, IntPtr.Zero);
        }

        public void Resume()
        {
            String commandPause = "resume Mediafile";
            mciSendString(commandPause, null, 0, IntPtr.Zero);
        }
    }
}
