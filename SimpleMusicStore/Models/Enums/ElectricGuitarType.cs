using System.ComponentModel.DataAnnotations;

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
