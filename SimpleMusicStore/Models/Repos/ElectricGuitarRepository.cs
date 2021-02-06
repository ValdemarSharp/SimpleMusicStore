using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class ElectricGuitarRepository
    {
        private readonly MusicStoreContext _context;

        public ElectricGuitarRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<List<ElectricGuitar>> GetAllAsync()
        {
            return _context.ElectricGuitars.ToListAsync();
        }
    }
}
