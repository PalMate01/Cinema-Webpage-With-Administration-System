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
    class itemsListPresenter
    {
        private itemsRepository repo;
        private IDataGridList<items> view;
        public itemsListPresenter(IDataGridList<items> param)
        {
            view = param;
            repo = new itemsRepository();
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

        public void Add(items item)
        {
            //0 --> a lista tetejére szúrja be
            view.bindingList.Insert(0, item);
            repo.Insert(item);
            view.totalItems++;
        }

        public void Modify(items item)
        {
            repo.Update(item);
        }

        public void Remove(int index)
        {
            var item = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(item.id);
            view.totalItems--;
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
