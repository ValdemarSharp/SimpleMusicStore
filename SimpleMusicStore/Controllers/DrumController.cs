using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.MusicalInstruments;
using SimpleMusicStore.Models.Repos;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class DrumController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private DrumRepository _drumRepo;

        public DrumController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _drumRepo = new DrumRepository(_musicStoreContext);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var itemToEdit = await _drumRepo.GetAsync(id.Value);
                if (itemToEdit != null)
                    return View(itemToEdit);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Drum item)
        {
            if (ModelState.IsValid)
            {
                await _drumRepo.UpdateAsync(item);
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }
    }
}
