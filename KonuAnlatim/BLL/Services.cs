using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Services
    {
        #region Instance
        KonuOdevDBContext db = new KonuOdevDBContext();
        Konu konu = new Konu();
        Ogrenci ogrenci = new Ogrenci();
        Random rnd = new Random();
        #endregion




        #region Random Sayı Verme
        public void Listele()
        {
            int[] sayiDizisi = new int[17];
            Console.WriteLine("KURA İŞLEMİ BAŞLATILDI ....... ");
            Console.WriteLine("===================================================");
            Console.Beep(1000, 2000);
            for (int i = 0; i < 17; i++)
            {

                int rastgele = rnd.Next(1, 18);
                sayiDizisi[i] = rastgele;
                for (int z = 0; z < i; z++)
                {
                    if (sayiDizisi[z] == sayiDizisi[i])
                    {
                        i--;
                        continue;
                    }
                }
            }
            #endregion
            #region Öğrenci Girişleri
            for (int i = 1; i < 16; i++)
            {
                Ogrenci updatedOgrenci = db.Ogrencis.FirstOrDefault(x => x.OgrenciId == i);
                updatedOgrenci.KonuId = sayiDizisi[i];
            }
                                    
            Ogrenci updatedOgrenci16 = db.Ogrencis.FirstOrDefault(x => x.OgrenciId == 17);
            updatedOgrenci16.KonuId = sayiDizisi[0];
            #endregion

            db.SaveChanges();

            //Linq to Entity
            var result = db.Ogrencis.Select(o => new
            {
                o.Konu.KonuAdi,
                o.OgrenciAd,
                o.OgrenciSoyad,

            }).ToList();

            foreach (var item in result)
            {

                Console.WriteLine($"Öğrenci Ad-Soyad {item.OgrenciAd} {item.OgrenciSoyad} -        Konu : {item.KonuAdi}\n");
            }

            Console.WriteLine("BAŞARILAR DİLERİZ...");
            Console.Read();
        }
    }
}
