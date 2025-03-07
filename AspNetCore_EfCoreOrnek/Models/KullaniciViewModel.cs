using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_EfCoreOrnek.Models
{
    public class KullaniciViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Zorunludur....")]
        public string KullaniciAdi { get; set; }


        [Display(Name = "Email Adres")]
        [Required(ErrorMessage = "Email Adres Zorunludur....")]
        [EmailAddress(ErrorMessage = "Lütfen email adresi giriniz")]
        public string Email { get; set; }



        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Zorunludur....")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Required(ErrorMessage = "Şifre Tekrar Zorunludur....")]
        [Compare("Sifre", ErrorMessage = "Şifre ile Şifre tekrarı aynı olmalıdır")] // sifre alanı ile karşılaştır..
		[DataType(DataType.Password)]
		public string SifreTekrar { get; set; }

        [Display(Name = "İsim")]
        public string? Adi { get; set; }

        [Display(Name = "Soyisim")]
        public string? SoyAdi { get; set; }
    }

    // Validation model sınıfının view'da doğrulnması durumudur. (zorunlu alanların girilmesi)

    // ModelState.IsValid propertisi ile actionda alanlrın doldulup doldurulmadığı öürenilir. true ise zorunlu alanlar doldurulmuştur...
}
