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
    class ordersListPresenter
    {
        private ordersRepository repo;
        private IDataGridList<orders> view;
        public ordersListPresenter(IDataGridList<orders> param)
        {
            view = param;
            repo = new ordersRepository();
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

        public void Add(orders order)
        {
            //0 --> a lista tetejére szúrja be
            view.bindingList.Insert(0, order);
            repo.Insert(order);
            view.totalItems++;
        }

        public void Modify(orders order)
        {
            repo.Update(order);
        }

        public void Remove(int index)
        {
            var order = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(order.id);
            view.totalItems--;
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
