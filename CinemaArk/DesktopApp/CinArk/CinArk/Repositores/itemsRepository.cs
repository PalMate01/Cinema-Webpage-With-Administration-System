using CinArk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Repositores
{
    class itemsRepository
    {
        private ArkContext db = new ArkContext();
        private int _totalItems;

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public BindingList<items> GetAll(
            int page = 1,
            int itemsPerPage = 10,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.items.OrderBy(x => x.customer_id).AsQueryable();

            //Keresés hónap vagy név alapján
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.month.Contains(search) ||
                                    x.user.name.Contains(search));
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "product_id":
                        query = ascending ? query.OrderBy(x => x.product_id) : query.OrderByDescending(x => x.product_id);
                        break;
                    case "quantity":
                        query = ascending ? query.OrderBy(x => x.quantity) : query.OrderByDescending(x => x.quantity);
                        break;
                    case "price":
                        query = ascending ? query.OrderBy(x => x.price) : query.OrderByDescending(x => x.price);
                        break;
                    case "order_id":
                        query = ascending ? query.OrderBy(x => x.order_id) : query.OrderByDescending(x => x.order_id);
                        break;
                    case "customer_id":
                        query = ascending ? query.OrderBy(x => x.customer_id) : query.OrderByDescending(x => x.customer_id);
                        break;
                    case "movie":
                        query = ascending ? query.OrderBy(x => x.movie) : query.OrderByDescending(x => x.movie);
                        break;
                    case "room":
                        query = ascending ? query.OrderBy(x => x.room) : query.OrderByDescending(x => x.room);
                        break;
                    case "line":
                        query = ascending ? query.OrderBy(x => x.line) : query.OrderByDescending(x => x.line);
                        break;
                    case "seat":
                        query = ascending ? query.OrderBy(x => x.seat) : query.OrderByDescending(x => x.seat);
                        break;
                    case "month":
                        query = ascending ? query.OrderBy(x => x.month) : query.OrderByDescending(x => x.month);
                        break;
                    case "day":
                        query = ascending ? query.OrderBy(x => x.day) : query.OrderByDescending(x => x.day);
                        break;
                    case "lecture":
                        query = ascending ? query.OrderBy(x => x.lecture) : query.OrderByDescending(x => x.lecture);
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

            return new BindingList<items>(query.ToList());
        }

        public bool Exists(int customer_id)
        {
            return db.items.Any(x => x.customer_id == customer_id);
        }

        public void Insert(items item)
        {
            db.items.Add(item);
        }

        public void Update(items uj_item)
        {
            //Régi rekord az adatbázisban
            var regi_item = db.items.Find(uj_item.id);
            if (regi_item != null)
            {
                //Az adatbázisban lévő rekord elemnek
                //beállítja az összes értékét a paraméterével
                db.Entry(regi_item).CurrentValues.SetValues(uj_item);
            }
        }

        public void Delete(int id)
        {
            var item = db.items.Find(id);
            if (item != null)
            {
                db.items.Remove(item);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


    }
}
