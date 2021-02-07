using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class AcousticGuitarRepository
    {
        private readonly MusicStoreContext _context;

        public AcousticGuitarRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<AcousticGuitar> GetAsync(int id)
        {
            return _context.AcousticGuitars.FirstOrDefaultAsync(eguitar => eguitar.Id == id);
        }

        public Task<List<AcousticGuitar>> GetAllAsync()
        {
            return _context.AcousticGuitars.ToListAsync();
        }

        public async Task UpdateAsync(AcousticGuitar item)
        {
            _context.AcousticGuitars.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
