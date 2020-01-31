using System;
using Microsoft.DirectX.DirectSound;

namespace SoundCard
{
    class DirectSoundPlayingMethod : IPlayingMethod, IPausable
    {
        private Device _device;
        private BufferDescription _bufferDescription;
        private SecondaryBuffer _buffer;
        private int _currentPosition;

        public DirectSoundPlayingMethod(IntPtr parent)
        {
            _device = new Device();
            _device.SetCooperativeLevel(parent, CooperativeLevel.Normal);
            _bufferDescription = new BufferDescription();
            _bufferDescription.ControlPan = true;
            _bufferDescription.ControlVolume = true;
            _bufferDescription.ControlFrequency = true;
            _bufferDescription.ControlEffects = true;
        }

        public void Play(string filename)
        {
            if (_buffer != null)
                _buffer.Stop();

            _buffer = new SecondaryBuffer(filename, _bufferDescription,_device);
            _buffer.Play(0, BufferPlayFlags.Default);
        }

        public void Stop()
        {
            if (_buffer != null)
                _buffer.Stop();
        }

        public void Pause()
        {
            if (_buffer != null)
            {
                _currentPosition = _buffer.PlayPosition;
                _buffer.Stop();
            }
        }

        public void Resume()
        {
            if (_buffer != null)
            {
                _buffer.SetCurrentPosition(_currentPosition);
                _buffer.Play(0, BufferPlayFlags.Default);
            }
        }
    }
}
