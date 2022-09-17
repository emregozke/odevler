using BLL;
using DataAccess.Models;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            tekrar:
                Console.WriteLine("ÖĞRENCİ KONU ANLATIMI SEÇİM KURASI\nBaşlatmak için [1] çıkmak için [2] TUŞLAYINIZ.");
                int cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == 1)
                {
                    Services services=new Services();
                    services.Listele();
                }
                else if (cevap == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("HATALI TUŞLADINIZ . TEKRAR DENEYİNİZ");
                    goto tekrar;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Environment.Exit(0);

            }






















        }
    }
}
