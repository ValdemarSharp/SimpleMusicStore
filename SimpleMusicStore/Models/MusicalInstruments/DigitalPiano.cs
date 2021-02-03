using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SimpleMusicStore.Models.Enums;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("DigitalPianos")]
    public class DigitalPiano : Product
    {
        public DigitalPianoType Type { get; set; }
    }
}
