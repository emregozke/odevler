using System;

namespace CA_Gavurdagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlServisET alServisET = new AlServisET();
            Console.WriteLine(alServisET.Al());
            Domates domates = new Domates();
            Console.WriteLine($"{ domates.Yıka()} {domates.Dogra()}");
            KırmızıSogan kırmızısogan = new KırmızıSogan();
            Console.WriteLine(kırmızısogan.Dogra());
            Biber biber = new Biber();
            Console.WriteLine($"{biber.Dogra()} {biber.Koy()}");
            Salatalık salatalık = new Salatalık();
            Console.WriteLine($"{salatalık.Dogra()} {salatalık.Koy()}");
            Ceviz ceviz = new Ceviz();
            Console.WriteLine(ceviz.Koy());
            Maydonoz maydonoz = new Maydonoz();
            Console.WriteLine(maydonoz.Koy());
            ZeytinYagi zeytinYagi = new ZeytinYagi();
            Console.WriteLine(zeytinYagi.Koy());
            NarEksisi narEksisi = new NarEksisi();
            Console.WriteLine(narEksisi.Koy());            
            Console.WriteLine(alServisET.ServisEt());

            Console.ReadLine();
            
            

        }
    }
}
