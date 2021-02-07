using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("AcousticGuitars")]
    public class AcousticGuitar : Product
    {
        //со звукоснимателем или без
        public bool WithPickup { get; set; }
    }
}
