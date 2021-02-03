using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMusicStore.Models.Enums;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    public class DigitalPiano : Product
    {
        public DigitalPianoType Type { get; set; }
    }
}
