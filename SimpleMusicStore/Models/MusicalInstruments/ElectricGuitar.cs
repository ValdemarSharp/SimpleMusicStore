using SimpleMusicStore.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("ElectricGuitars")]
    public class ElectricGuitar : Product
    {
        public ElectricGuitarType Type { get; set; }
    }
}
