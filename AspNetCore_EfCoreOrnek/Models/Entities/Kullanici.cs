﻿namespace AspNetCore_EfCoreOrnek.Models.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string? Adi { get; set; }
        public string? SoyAdi { get; set; }
    }
}
