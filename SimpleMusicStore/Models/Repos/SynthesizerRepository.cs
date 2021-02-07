using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class SynthesizerRepository
    {
        private readonly MusicStoreContext _context;

        public SynthesizerRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<Synthesizer> GetAsync(int id)
        {
            return _context.Synthesizers.FirstOrDefaultAsync(eguitar => eguitar.Id == id);
        }

        public Task<List<Synthesizer>> GetAllAsync()
        {
            return _context.Synthesizers.ToListAsync();
        }

        public async Task UpdateAsync(Synthesizer item)
        {
            _context.Synthesizers.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
