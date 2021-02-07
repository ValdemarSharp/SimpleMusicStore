using System.Collections.Generic;

namespace SimpleMusicStore.Models.ViewModels
{
    /// <summary>
    /// Используется для вывода всей необходимой информации на главной странице
    /// </summary>
    public class AllContent
    {
        public List<Firm> Firms { get; set; }
        public List<Product> Products { get; set; }
    }
}
