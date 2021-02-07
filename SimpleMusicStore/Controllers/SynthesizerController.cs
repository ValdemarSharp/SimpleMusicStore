using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.MusicalInstruments;
using SimpleMusicStore.Models.Repos;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class SynthesizerController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private SynthesizerRepository _synthesizerRepo;

        public SynthesizerController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _synthesizerRepo = new SynthesizerRepository(_musicStoreContext);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var itemToEdit = await _synthesizerRepo.GetAsync(id.Value);
                if (itemToEdit != null)
                    return View(itemToEdit);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Synthesizer item)
        {
            if (ModelState.IsValid)
            {
                await _synthesizerRepo.UpdateAsync(item);
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }
    }
}
