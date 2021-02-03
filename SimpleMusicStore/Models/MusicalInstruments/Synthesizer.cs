using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SimpleMusicStore.Models.Enums;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("Synthesizers")]
    public class Synthesizer : Product
    {
        public SynthesizerType Type { get; set; }
    }
}
