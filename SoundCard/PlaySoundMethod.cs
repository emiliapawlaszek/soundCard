using System.IO;
using System.Media;

namespace SoundCard
{
    public struct WaveHeader
    {
        public byte[] riffID;
        public uint size;
        public byte[] wavID;
        public byte[] fmtID;
        public uint fmtSize;
        public ushort format;
        public ushort channels;
        public uint sampleRate;
        public uint bytePerSec;
        public ushort blockSize;
        public ushort bit;
        public byte[] dataID;
        public uint dataSize;
        public byte[] rawSound;
        
        public override string ToString()
        {
            //słowny zapis typu kanału
            string tempChannel;
            if (channels == 1)
                tempChannel = "mono";
            else if (channels == 2)
                tempChannel = "stereo";
            else
            {
                tempChannel = "unrecognized";
            }

            return "size: " + size + "\r\n" +
                   "formtSize: " + fmtSize + "\r\n" +
                   "dataSize: " + dataSize + "\r\n" +
                   "sampleRate: " + sampleRate + "\r\n" +
                   "channel: " + channels + " zatem " + tempChannel + "\r\n";

        }
    }
    class PlaySoundMethod : IPlayingMethod
    {
        public WaveHeader header;
        private SoundPlayer _soundPlayer = new SoundPlayer();

        ~PlaySoundMethod()
        {
            _soundPlayer.Dispose();
        }

        public void Play(string filename)
        {
            _soundPlayer.SoundLocation = filename;
            _soundPlayer.Play();


                header = new WaveHeader();

            using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                try
                {
                    //pobiera kolejno dane pliku .wav
                    header.riffID = binaryReader.ReadBytes(4);
                    header.size = binaryReader.ReadUInt32();
                    header.wavID = binaryReader.ReadBytes(4);
                    header.fmtID = binaryReader.ReadBytes(4);
                    header.fmtSize = binaryReader.ReadUInt32();
                    header.format = binaryReader.ReadUInt16();
                    header.channels = binaryReader.ReadUInt16();
                    header.sampleRate = binaryReader.ReadUInt32();
                    header.bytePerSec = binaryReader.ReadUInt32();
                    header.blockSize = binaryReader.ReadUInt16();
                    header.bit = binaryReader.ReadUInt16();
                    header.dataID = binaryReader.ReadBytes(4);
                    header.dataSize = binaryReader.ReadUInt32();
                    header.rawSound = binaryReader.ReadBytes((int)header.dataSize);



                }
                finally
                {
                    binaryReader.Close();
                    fileStream.Close();
                }
            }

            System.Console.WriteLine("size: ");
            System.Console.WriteLine(header.size);
                 System.Console.WriteLine("formtSize: ");
                 System.Console.WriteLine(header.fmtSize);
                 System.Console.WriteLine("dataSize: ");
                 System.Console.WriteLine(header.dataSize);
                 System.Console.WriteLine("sampleRate: ");
                 System.Console.WriteLine(header.sampleRate);
            System.Console.WriteLine("channel: ");
            System.Console.WriteLine(header.channels);


        }

        public void Stop()
        {
            _soundPlayer.Stop();
        }
    }
}
