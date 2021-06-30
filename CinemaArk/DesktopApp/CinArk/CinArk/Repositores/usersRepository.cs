using CinArk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Repositores
{
    class usersRepository
    {
        private ArkContext db = new ArkContext();
        private int _totalItems;

        public int TotalItems
        {
            get { return _totalItems; }
        }

        //Az 60-as id az admin fiók jelenleg
        public bool autentic(string username, string pass)
        {
            return db.user.Any(x => x.username == username && x.pwd == pass && x.id == 60);
        }

        public int GetId(string username)
        {
            var nev = db.user.SingleOrDefault(x => x.username == username);
            if (username != null)
            {
                return nev.id;
            }
            return 0;
        }

        public BindingList<user> GetAll(
            int page = 1,
            int itemsPerPage = 10,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.user.OrderBy(x => x.name).AsQueryable();

            //Keresés név, felhasználónév, lakcím alapján
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.name.Contains(search) ||
                                    x.home_address.Contains(search) ||
                                    x.username.Contains(search));
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "username":
                        query = ascending ? query.OrderBy(x => x.username) : query.OrderByDescending(x => x.username);
                        break;
                    case "name":
                        query = ascending ? query.OrderBy(x => x.name) : query.OrderByDescending(x => x.name);
                        break;
                    case "email":
                        query = ascending ? query.OrderBy(x => x.email) : query.OrderByDescending(x => x.email);
                        break;
                    case "home_address":
                        query = ascending ? query.OrderBy(x => x.home_address) : query.OrderByDescending(x => x.home_address);
                        break;
                    case "join_date":
                        query = ascending ? query.OrderBy(x => x.join_date) : query.OrderByDescending(x => x.join_date);
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

            return new BindingList<user>(query.ToList());
        }

        public bool Exists(string username)
        {
            return db.user.Any(x => x.username == username);
        }

        public void Insert(user user)
        {
            db.user.Add(user);
        }

        public void Update(user new_user)
        {
            //Régi rekord az adatbázisban
            var old_user = db.user.Find(new_user.id);
            if (old_user != null)
            {
                //Az adatbázisban lévő rekord elemnek
                //beállítja az összes értékét a paraméterével
                db.Entry(old_user).CurrentValues.SetValues(new_user);
            }
        }

        public void Delete(int id)
        {
            var user = db.user.Find(id);
            if (user != null)
            {
                db.user.Remove(user);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
