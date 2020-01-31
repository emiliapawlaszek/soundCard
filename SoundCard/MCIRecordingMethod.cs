using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SoundCard
{
    class MCIRecordingMethod : IRecordingMethod
    {
        private bool IsRecording
        {
            get; set;
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command,
    StringBuilder retstring, int ReturnLength, IntPtr callback);

        public void Record()
        {
            String commandOpenNew = "open new type waveaudio alias wavfile";
            mciSendString(commandOpenNew, null, 0, IntPtr.Zero);

            String commandRecord = "record wavfile";
            mciSendString(commandRecord, null, 0, IntPtr.Zero);

            IsRecording = true;
        }

        public void AbortRecording()
        {
            if (IsRecording)
            {
                String commandClose = "close wavfile";
                mciSendString(commandClose, null, 0, IntPtr.Zero);
            }

            IsRecording = false;
        }

        public void Save(string filename)
        {
            String commandStop = "stop wavfile " + filename;
            mciSendString(commandStop, null, 0, IntPtr.Zero);

            String commandSave = "save wavfile " + filename;
            mciSendString(commandSave, null, 0, IntPtr.Zero);

            String commandClose = "close wavfile";
            mciSendString(commandClose, null, 0, IntPtr.Zero);

            IsRecording = false;
        }
    }
}
