using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kitapSitesi.Models
{
    public class tabanPuanlari
    {
        public int id { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }
        public double Puan { get; set; }
        public int Siralama { get; set; }

        public static List<tabanPuanlari> puanlar = new List<tabanPuanlari>
        {
            new tabanPuanlari
            {
                id = 1,
                Fakulte = "Mühendislik Fakültesi",
                Bolum = "Makine Mühendisliği",
                Puan = 467.45,
                Siralama = 12046, 
            },
            new tabanPuanlari
            {
                id = 2,
                Fakulte = "Mühendislik Fakültesi",
                Bolum = "Elektrik Mühendisliği",
                Puan = 477.41,
                Siralama = 9682,
            },
            new tabanPuanlari
            {
                id = 3,
                Fakulte = "Mühendislik Fakültesi",
                Bolum = "Bilgisayar Mühendisliği",
                Puan = 491.10,
                Siralama = 4003,
            },
            new tabanPuanlari
            {
                id = 4,
                Fakulte = "Sağlık Fakültesi",
                Bolum = "Tıp",
                Puan = 503.95,
                Siralama = 3110,
            },
            new tabanPuanlari
            {
                id = 5,
                Fakulte = "Sağlık Fakültesi",
                Bolum = "Eczacılık",
                Puan = 480.92,
                Siralama = 6789,
            },
            new tabanPuanlari
            {
                id = 6,
                Fakulte = "Sağlık Fakültesi",
                Bolum = "Veterinerlik",
                Puan = 450.62,
                Siralama = 14670,
            },
            new tabanPuanlari
            {
                id = 7,
                Fakulte = "Sağlık Fakültesi",
                Bolum = "Diş Hekimliği",
                Puan = 499.46,
                Siralama = 3566,
            },
            new tabanPuanlari
            {
                id = 8,
                Fakulte = "Fen Fakültesi",
                Bolum = "Matematik",
                Puan = 422.18,
                Siralama = 16750,
            },
            new tabanPuanlari
            {
                id = 9,
                Fakulte = "Fen Fakültesi",
                Bolum = "Fizik",
                Puan = 490.00,
                Siralama = 3100,
            },
            new tabanPuanlari
            {
                id = 10,
                Fakulte = "Fen Fakültesi",
                Bolum = "Kimya",
                Puan = 434.99,
                Siralama = 15002,
            },
            new tabanPuanlari
            {
                id = 11,
                Fakulte = "Fen Fakültesi",
                Bolum = "Biyoloji",
                Puan = 451.02,
                Siralama = 14695,
            },
        };
    }
}