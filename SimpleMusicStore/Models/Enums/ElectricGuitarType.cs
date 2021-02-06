using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Enums
{
    public enum ElectricGuitarType
    {
        [Display(Name = "Half-acoustic")]
        HalfAcoustic, //полуакустическая
        [Display(Name = "Solid-body")]
        SolidBody //цельнокорпусная
    }
}
