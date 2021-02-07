using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class FirmRepository
    {
        private readonly MusicStoreContext _context;

        public FirmRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            
        }

        public Task<Firm> GetAsync(int id)
        {
            return _context.Firms.FirstOrDefaultAsync(eguitar => eguitar.Id == id);
        }

        public Task<List<Firm>> GetAllAsync()
        {
            return _context.Firms.ToListAsync();
        }

        public async Task UpdateAsync(Firm item)
        {
            _context.Firms.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
