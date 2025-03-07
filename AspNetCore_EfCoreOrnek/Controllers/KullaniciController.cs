using AspNetCore_EfCoreOrnek.Models;
using AspNetCore_EfCoreOrnek.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_EfCoreOrnek.Controllers
{
    public class KullaniciController : Controller
    {
        // asp.net core mvc'de instance'lar ıOc container'da oluşturulup dağıtılır. Bu instance program.cs dosyasında oluşturulur ve instance isteyen controllerlara gönderilir...



        //KullaniciDbContext dbContext = new KullaniciDbContext()
        KullaniciDbContext _dbContext;
        public KullaniciController(KullaniciDbContext dbContext)
        {
            _dbContext = dbContext; // program.cs dosyasındaki Services.AddDbContext metodu bu controllera instance constructordan gönderir..
        }


        public IActionResult Kayit()
        {

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Kayit(KullaniciViewModel kullanici)
        {
            
            if (ModelState.IsValid) // model doğrulandıysa
            {
                Kullanici k = new Kullanici();
                k.KullaniciAdi = kullanici.KullaniciAdi;
                k.Email = kullanici.Email;
                k.Sifre = kullanici.Sifre;
                k.Adi = kullanici.Adi;
                k.SoyAdi = kullanici.SoyAdi;

                _dbContext.Kullanici.Add(k);
                _dbContext.SaveChanges();

                ViewBag.Message = "Kayıt İşlemi Başarılı";
            }

            return View();
        }

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Giris(KullaniciViewModel vm)
        {
			return View();
		}
	}
}
