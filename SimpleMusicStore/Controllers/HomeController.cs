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
        private AcousticGuitarRepository _acousticGuitarRepo;
        private DrumRepository _drumRepo;
        private SynthesizerRepository _synthesizerRepo;
        private DigitalPianoRepository _digitalPianoRepo;

        public HomeController(MusicStoreContext context)
        {
            _musicStoreContext = context;
            _firmRepo = new FirmRepository(_musicStoreContext);
            _productRepo = new ProductRepository(_musicStoreContext);
            _electricGuitarRepo = new ElectricGuitarRepository(_musicStoreContext);
            _drumRepo = new DrumRepository(_musicStoreContext);
            _acousticGuitarRepo = new AcousticGuitarRepository(_musicStoreContext);
            _synthesizerRepo = new SynthesizerRepository(_musicStoreContext);
            _digitalPianoRepo = new DigitalPianoRepository(_musicStoreContext);
        }
        public async Task<IActionResult> Index()
        {
            var electricGuitars = await _electricGuitarRepo.GetAllAsync();
            var acousticGuitars = await _acousticGuitarRepo.GetAllAsync();
            var synthesizers = await _synthesizerRepo.GetAllAsync();
            var drums = await _drumRepo.GetAllAsync();
            var digitalPianos = await _digitalPianoRepo.GetAllAsync();
            var allProducts = new List<Product>();
            allProducts = allProducts.Concat(electricGuitars).Concat(acousticGuitars).Concat(synthesizers).Concat(drums).Concat(digitalPianos).ToList();

            var result = new AllContent
            {
                Products = allProducts,
                Firms = await _firmRepo.GetAllAsync(),
                ElectricGuitars = await _electricGuitarRepo.GetAllAsync()

            };
            return View(result);
        }
    }
}
