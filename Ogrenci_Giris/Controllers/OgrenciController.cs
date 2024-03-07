using Microsoft.AspNetCore.Mvc;
using Ogrenci_Giris.Models;

namespace Ogrenci_Giris.Controllers
{
    public class OgrenciController : Controller
    {
        static List<ogrenciBilgi> ogrenciler = new List<ogrenciBilgi>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Listele(ogrenciBilgi ogrenci)
        {
            return View(ogrenciler);
        }
        [HttpGet]
        public IActionResult Gonder(ogrenciBilgi ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return RedirectToAction("Index");
        }
       
    }
}
