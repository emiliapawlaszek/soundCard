using System;

namespace SoundCard
{
    interface IRecordingMethod
    {
        void Record();
        void AbortRecording();
        void Save(String filename);
    }
}
