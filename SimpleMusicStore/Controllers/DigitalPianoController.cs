using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.MusicalInstruments;
using SimpleMusicStore.Models.Repos;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class DigitalPianoController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private DigitalPianoRepository _digitalPianoRepo;

        public DigitalPianoController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _digitalPianoRepo = new DigitalPianoRepository(_musicStoreContext);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var itemToEdit = await _digitalPianoRepo.GetAsync(id.Value);
                if (itemToEdit != null)
                    return View(itemToEdit);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DigitalPiano item)
        {
            if (ModelState.IsValid)
            {
                await _digitalPianoRepo.UpdateAsync(item);
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }
    }
}
