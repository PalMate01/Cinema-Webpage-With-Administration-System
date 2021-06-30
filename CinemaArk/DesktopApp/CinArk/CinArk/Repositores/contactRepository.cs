using CinArk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Repositores
{
    class contactRepository
    {
        
        private ArkContext db = new ArkContext();
        private int _totalItems;

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public BindingList<contact> GetAll(
            int page = 1,
            int itemsPerPage = 10,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.contact.OrderBy(x => x.id).AsQueryable();

            //Keresés név alapján
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.user.name.Contains(search));
            }

            //Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "name_id":
                        query = ascending ? query.OrderBy(x => x.name_id) : query.OrderByDescending(x => x.name_id);
                        break;
                    case "message":
                        query = ascending ? query.OrderBy(x => x.message) : query.OrderByDescending(x => x.message);
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

            return new BindingList<contact>(query.ToList());
        }

        public void Delete(int id)
        {
            var contact = db.contact.Find(id);
            if (contact != null)
            {
                db.contact.Remove(contact);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
