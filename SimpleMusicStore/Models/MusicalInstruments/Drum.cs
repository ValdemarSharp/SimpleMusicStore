using SimpleMusicStore.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("Drums")]
    public class Drum : Product
    {
        public DrumType Type { get; set; }
    }
}
