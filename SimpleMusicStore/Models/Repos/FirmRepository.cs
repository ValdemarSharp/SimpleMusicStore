using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<List<Firm>> GetAllAsync()
        {
            return _context.Firms.ToListAsync();
        }
    }
}
