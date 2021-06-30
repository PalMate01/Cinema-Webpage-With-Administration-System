using CinArk.Models;
using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    class contactListPresenter
    {
        private contactRepository repo;
        private IDataGridList<contact> view;
        public contactListPresenter(IDataGridList<contact> param)
        {
            view = param;
            repo = new contactRepository();
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAll(
                view.page,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending);

            view.totalItems = repo.TotalItems;
        }

        public void Remove(int index)
        {
            var contact = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(contact.id);
            view.totalItems--;
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
