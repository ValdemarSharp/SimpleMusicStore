﻿using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Models.MusicalInstruments;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleMusicStore.Models.Repos
{
    public class DigitalPianoRepository
    {
        private readonly MusicStoreContext _context;

        public DigitalPianoRepository(MusicStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Task<DigitalPiano> GetAsync(int id)
        {
            return _context.DigitalPianos.FirstOrDefaultAsync(eguitar => eguitar.Id == id);
        }

        public Task<List<DigitalPiano>> GetAllAsync()
        {
            return _context.DigitalPianos.ToListAsync();
        }

        public async Task UpdateAsync(DigitalPiano item)
        {
            _context.DigitalPianos.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
