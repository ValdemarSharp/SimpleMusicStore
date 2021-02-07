using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class ProductRepository
    {
        private readonly MusicStoreContext _context;

        public ProductRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<List<Product>> GetAllAsync()
        {
            return _context.Products.ToListAsync();
        }
    }
}
