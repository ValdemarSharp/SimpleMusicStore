using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
