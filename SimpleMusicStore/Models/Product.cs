using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указана цена")]
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "Недопустимая цена")]
        [RegularExpression(@"^[0-9]\d{0,9}(\,\d{2})?%?$", ErrorMessage = "Формат цены может содержать целое число либо дробное число с символом ',' и двумя цифрами после ','")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано название")]
        [StringLength(maximumLength: 300, ErrorMessage = "Максимально допустимое количество символов: 300")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        [StringLength(maximumLength: 2000, ErrorMessage = "Максимально допустимое количество символов: 2000")]
        public string Description { get; set; }

        [Required]
        public string PhotoUrl { get; set; }

        public Firm Firm { get; set; }
    }
}
