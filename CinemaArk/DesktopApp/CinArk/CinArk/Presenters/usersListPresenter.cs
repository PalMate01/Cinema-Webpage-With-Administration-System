using CinArk.Models;
using CinArk.Properties;
using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    class usersListPresenter
    {
        private usersRepository repo;
        private IDataGridList<user> view;
        
        public usersListPresenter(IDataGridList<user> param)
        {
            view = param;
            repo = new usersRepository();
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

        public void Add(user user)
        {
            //0 --> a lista tetejére szúrja be
            view.bindingList.Insert(0, user);
            repo.Insert(user);
            view.totalItems++;
        }

        public void Modify(user user)
        {
            repo.Update(user);
        }

        public void Remove(int index)
        {
            var user = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(user.id);
            view.totalItems--;
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
