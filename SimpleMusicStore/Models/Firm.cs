using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleMusicStore.Models
{
    public class Firm
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано название")]
        [StringLength(maximumLength: 100, ErrorMessage = "Максимально допустимое количество символов: 100")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        [StringLength(maximumLength: 1000, ErrorMessage = "Максимально допустимое количество символов: 1000")]
        public string Description { get; set; }

        public ICollection<Product> MusicalInstruments { get; set; }
    }
}
