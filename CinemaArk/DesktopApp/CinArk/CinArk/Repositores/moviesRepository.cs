using CinArk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Repositores
{
    class moviesRepository
    {
        private ArkContext db = new ArkContext();

        private int _totalItems;

        public int TotalItems
        {
            get { return _totalItems; }
        }


        public BindingList<movies> GetAll(
            int page = 1,
            int itemsPerPage = 5,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.movies.OrderBy(x => x.title).AsQueryable();

            //Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.title.Contains(search));
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "title":
                        query = ascending ? query.OrderBy(x => x.title) : query.OrderByDescending(x => x.title);
                        break;
                    case "genre":
                        query = ascending ? query.OrderBy(x => x.genre) : query.OrderByDescending(x => x.genre);
                        break;
                    case "rating":
                        query = ascending ? query.OrderBy(x => x.rating) : query.OrderByDescending(x => x.rating);
                        break;
                    case "lenght":
                        query = ascending ? query.OrderBy(x => x.lenght) : query.OrderByDescending(x => x.lenght);
                        break;
                    case "release_date":
                        query = ascending ? query.OrderBy(x => x.release_date) : query.OrderByDescending(x => x.release_date);
                        break;
                    case "room":
                        query = ascending ? query.OrderBy(x => x.room) : query.OrderByDescending(x => x.room);
                        break;
                    default:
                        break;
                }
            }

            //Összes találat
            _totalItems = query.Count();

            //Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<movies>(query.ToList());
        }

        public bool Exists(string title)
        {
            return db.movies.Any(x => x.title == title);
        }

        public void Insert(movies movie)
        {
            db.movies.Add(movie);
        }

        public void Update(movies uj_movie)
        {
            //Régi rekord az adatbázisban
            var regi_movie = db.movies.Find(uj_movie.id);
            if (regi_movie != null)
            {
                //Az adatbázisban lévő rekord elemnek
                //beállítja az összes értékét a paraméterével
                db.Entry(regi_movie).CurrentValues.SetValues(uj_movie);
            }
        }

        public void Delete(int id)
        {
            var movie = db.movies.Find(id);
            if (movie != null)
            {
                db.movies.Remove(movie);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
