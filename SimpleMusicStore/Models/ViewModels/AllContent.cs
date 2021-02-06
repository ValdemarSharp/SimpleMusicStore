using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.ViewModels
{
    public class AllContent
    {
        public List<Firm> Firms { get; set; }
        public List<Product> Products { get; set; }
    }
}
