using CA_imdbDataOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_imdbDataOdev
{
    public class MovieRepository
    {
        ImdbDataContext db = new ImdbDataContext();


        public List<Movie> MovieList()
        {
            return db.Movies.ToList();
        }
        public void Listele()
        {
            foreach (Movie item in db.Movies.ToList())
            {
                Console.WriteLine($"Id: {item.Id} Film Yılı: {item.Year} Film Puanı: {item.Rating} Film İsmi: {item.Title}");
            }
        }
        public void YilaGoreListe()
        {
            foreach (Movie film in db.Movies.Where(x => x.Year > int.Parse(Console.ReadLine())))
            {
                Console.WriteLine($"Film Adı: {film.Title} Film Yılı: {film.Year}");
            }
        }
        public void PuanaGoreListe()
        {
            foreach (Movie film in db.Movies.Where(x => x.Rating > int.Parse(Console.ReadLine())))
            {
                Console.WriteLine($"Film Adı: {film.Title} Film Yılı: {film.Year} Film Puanı: {film.Rating}");
            }
        }
        public void FilmArama()
        {
            foreach (Movie film2 in db.Movies.Where(x => x.Description.Contains(Console.ReadLine())))
            {
                Console.WriteLine($"Film Adı: {film2.Title} Film Yılı: {film2.Year} Film Puanı: {film2.Rating}");
            }
        }
        public void TureGoreFilmler()
        {

            var result = from m in db.Movies
                         join mg in db.MovieGenres on m.Id equals mg.MovieId
                         join g in db.Genres on mg.GenreId equals g.Id
                         select new
                         {
                             Tur = g.Name,
                             Title = m.Title
                         };

            foreach (var item in result.Where(x => x.Tur == Console.ReadLine()))
            {
                Console.WriteLine($"Film Adı: {item.Title}");

            }
        }
        public void RastgeleFilm()
        {
            Random rnd = new Random();
            int rastgele = rnd.Next(1, 1001);
            Console.WriteLine(rastgele);
            foreach (Movie item in db.Movies.Where(x => x.Id == rastgele))
            {
                Console.WriteLine($"Film Adı: {item.Title}");
            }
        }
        public void PuanaGoreRastgeleFilm()
        {

            Random rnd2 = new Random();
            int rastgele2 = rnd2.Next(1, 1001);
            Console.WriteLine("Puan Giriniz.");
            int puan = int.Parse(Console.ReadLine());

            foreach (Movie item in db.Movies.Where(x => x.Id == rastgele2 && x.Rating > puan))
            {
                Console.WriteLine($"Film Adı: {item.Title}");
            }

        }
    }
}
