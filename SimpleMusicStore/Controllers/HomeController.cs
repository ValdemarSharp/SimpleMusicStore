using Microsoft.AspNetCore.Mvc;
using SimpleMusicStore.Models;
using SimpleMusicStore.Models.Repos;
using SimpleMusicStore.Models.ViewModels;
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
        private ProductRepository _productRepo;
        private ElectricGuitarRepository _electricGuitarRepo;
        public HomeController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _firmRepo = new FirmRepository(_musicStoreContext);
            _productRepo = new ProductRepository(_musicStoreContext);
            _electricGuitarRepo = new ElectricGuitarRepository(_musicStoreContext);
        }
        public async Task<IActionResult> Index()
        {
            var result = new AllContent
            {
                Products = await _productRepo.GetAllAsync(),
                Firms = await _firmRepo.GetAllAsync(),
                ElectricGuitars = await _electricGuitarRepo.GetAllAsync()

            };
            return View(result);
        }
    }
}
