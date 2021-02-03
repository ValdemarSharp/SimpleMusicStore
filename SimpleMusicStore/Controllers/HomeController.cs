using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreContext _musicStoreContext;
        private FirmRepository _firmRepo;
        public HomeController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _firmRepo = new FirmRepository(_musicStoreContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _firmRepo.GetAllAsync());
        }
    }
}
