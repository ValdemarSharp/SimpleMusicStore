﻿using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.MusicalInstruments;
using SimpleMusicStore.Models.Repos;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class ElectricGuitarController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private ElectricGuitarRepository _electricGuitarRepo;

        public ElectricGuitarController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _electricGuitarRepo = new ElectricGuitarRepository(_musicStoreContext);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var itemToEdit = await _electricGuitarRepo.GetAsync(id.Value);
                if (itemToEdit != null)
                    return View(itemToEdit);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ElectricGuitar item)
        {
            if (ModelState.IsValid)
            {
                await _electricGuitarRepo.UpdateAsync(item);
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }
    }
}
