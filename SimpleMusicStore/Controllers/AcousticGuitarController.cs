using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.MusicalInstruments;
using SimpleMusicStore.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class AcousticGuitarController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private AcousticGuitarRepository _acousticGuitarRepo;

        public AcousticGuitarController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _acousticGuitarRepo = new AcousticGuitarRepository(_musicStoreContext);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var itemToEdit = await _acousticGuitarRepo.GetAsync(id.Value);
                if (itemToEdit != null)
                    return View(itemToEdit);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AcousticGuitar item)
        {
            if (ModelState.IsValid)
            {
                await _acousticGuitarRepo.UpdateAsync(item);
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }
    }
}
