using SimpleMusicStore.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("DigitalPianos")]
    public class DigitalPiano : Product
    {
        public DigitalPianoType Type { get; set; }
    }
}
