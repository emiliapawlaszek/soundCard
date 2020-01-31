using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCard
{
    interface IPlayingMethod
    {
        void Play(String filename);
        void Stop();
    }
}
