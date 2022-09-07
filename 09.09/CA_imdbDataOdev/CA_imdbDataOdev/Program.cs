using CA_imdbDataOdev.Models;
using System;

namespace CA_imdbDataOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieRepository moviesRepository = new MovieRepository();

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"1-Film listeleme.\r\n2-kullanıcıdan alınan yıl değerinden sonra çıkan filmleri listeleme.\r\n3-kullanıcıdan alınan puan'ın üzerinde olan filmleri listeleme.\r\n4-kullanıcıdan alınan değer açıklama bölümünde bulunan filmleri listeleme.\r\n5-kullanıcıdan alınan tür'e göre filmleri listeleme.\r\n6-rastgele film getirme.\r\n7-kullanıcıdan alınan puan aralığında rastgele film getirme.\r\n");
                int gelen = int.Parse(Console.ReadLine());
                try
                {
                    switch (gelen)
                    {
                        case 1:
                            moviesRepository.Listele();
                            break;
                        case 2:
                            Console.WriteLine("Bir Yıl Giriniz: ");
                            moviesRepository.YilaGoreListe();
                            break;
                        case 3:
                            Console.WriteLine("İstediğiniz Puanı Girin: ");
                            moviesRepository.PuanaGoreListe();
                            break;
                        case 4:
                            Console.WriteLine("Açıklamada bir değer Girin: ");
                            moviesRepository.FilmArama();
                            break;
                        case 5:
                            Console.WriteLine("Listelemek istediğiniz Film Türünü Girin: ");
                            moviesRepository.TureGoreFilmler();

                            break;
                        case 6:

                            moviesRepository.RastgeleFilm();
                            break;
                        case 7:

                            moviesRepository.PuanaGoreRastgeleFilm();
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
