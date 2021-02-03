using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SimpleMusicStore.Models.Enums;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("ElectricGuitars")]
    public class ElectricGuitar : Product
    {
        public ElectricGuitarType Type { get; set; }
    }
}
