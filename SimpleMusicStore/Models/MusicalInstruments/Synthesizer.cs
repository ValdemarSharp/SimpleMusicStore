using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMusicStore.Models.Enums;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    public class Synthesizer : Product
    {
        public SynthesizerType Type { get; set; }
    }
}
