using System.ComponentModel.DataAnnotations;

namespace SimpleMusicStore.Models.Enums
{
    public enum SynthesizerType
    {
        Standart,
        Studio,
        [Display(Name = "For kids")]
        ForKids
    }
}
