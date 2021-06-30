using CinArk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Repositores
{
    class ordersRepository
    {
        private ArkContext db = new ArkContext();
        private int _totalItems;

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public BindingList<orders> GetAll(
            int page = 1,
            int itemsPerPage = 10,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.orders.OrderBy(x => x.date).AsQueryable();

            //Keresés A megrendelő neve alapján
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.user.name.Contains(search));
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "customer_id":
                        query = ascending ? query.OrderBy(x => x.customer_id) : query.OrderByDescending(x => x.customer_id);
                        break;
                    case "date":
                        query = ascending ? query.OrderBy(x => x.date) : query.OrderByDescending(x => x.date);
                        break;
                    case "payment_mode":
                        query = ascending ? query.OrderBy(x => x.payment_mode) : query.OrderByDescending(x => x.payment_mode);
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

            return new BindingList<orders>(query.ToList());
        }

        public bool Exists(int id)
        {
            return db.orders.Any(x => x.id == id);
        }

        public void Insert(orders order)
        {
            db.orders.Add(order);
        }

        public void Update(orders uj_order)
        {
            //Régi rekord az adatbázisban
            var regi_order = db.orders.Find(uj_order.id);
            if (regi_order != null)
            {
                //Az adatbázisban lévő rekord elemnek
                //beállítja az összes értékét a paraméterével
                db.Entry(regi_order).CurrentValues.SetValues(uj_order);
            }
        }

        public void Delete(int id)
        {
            var order = db.orders.Find(id);
            if (order != null)
            {
                db.orders.Remove(order);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
