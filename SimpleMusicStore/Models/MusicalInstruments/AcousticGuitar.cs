using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.MusicalInstruments
{
    [Table("AcousticGuitars")]
    public class AcousticGuitar : Product
    {
        //со звукоснимателем или без
        public bool WithPickup { get; set; }
    }
}
