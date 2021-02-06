using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET: ElectricGuitarController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var eguitar = await _electricGuitarRepo.GetAsync(id);
            return View(eguitar);
        }

        // POST: ElectricGuitarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
