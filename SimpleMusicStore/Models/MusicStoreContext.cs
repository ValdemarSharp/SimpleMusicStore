using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ElectricGuitar> ElectricGuitars { get; set; }
        public DbSet<AcousticGuitar> AcousticGuitars { get; set; }
        public DbSet<DigitalPiano> DigitalPianos { get; set; }
        public DbSet<Synthesizer> Synthesizers { get; set; }
        public DbSet<Drum> Drums { get; set; }
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
