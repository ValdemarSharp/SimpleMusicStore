using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class DrumRepository
    {
        private readonly MusicStoreContext _context;
        public DrumRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<Drum> GetAsync(int id)
        {
            return _context.Drums.FirstOrDefaultAsync(eguitar => eguitar.Id == id);
        }

        public Task<List<Drum>> GetAllAsync()
        {
            return _context.Drums.ToListAsync();
        }

        public async Task UpdateAsync(Drum item)
        {
            _context.Drums.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
