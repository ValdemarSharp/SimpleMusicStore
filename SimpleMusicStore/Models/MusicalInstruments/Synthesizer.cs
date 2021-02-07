using SimpleMusicStore.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("Synthesizers")]
    public class Synthesizer : Product
    {
        public SynthesizerType Type { get; set; }
    }
}
