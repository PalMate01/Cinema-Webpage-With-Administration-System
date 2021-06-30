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
    class moviesListPresenter
    {
        private moviesRepository repo;
        private IDataGridList<movies> view;
        public moviesListPresenter(IDataGridList<movies> param)
        {
            view = param;
            repo = new moviesRepository();
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

        public void Add(movies movie)
        {
            //0 --> a lista tetejére szúrja be
            view.bindingList.Insert(0, movie);
            repo.Insert(movie);
            view.totalItems++;
        }

        public void Modify(movies movie)
        {
            repo.Update(movie);
        }

        public void Remove(int index)
        {
            var movie = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(movie.id);
            view.totalItems--;
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
