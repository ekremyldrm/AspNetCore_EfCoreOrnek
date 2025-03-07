using System.ComponentModel.DataAnnotations;

namespace AspNetCore_EfCoreOrnek.Models.Entities
{
    public class Kategori
    {
        [ScaffoldColumn(false)]
        public int KategoriId { get; set; }
        public string? KategoriAdi { get; set; }
        public string? KategoriAciklama { get; set; }
    }
}
