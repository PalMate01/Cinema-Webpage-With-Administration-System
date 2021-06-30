using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    //Új film létrehozásához szükséges
    //Van-e már ugyan olyan című film az adatbázisban
    class moviesPresenter
    {
        ImoviesView view;
        moviesRepository repo;
        public moviesPresenter(ImoviesView param)
        {
            view = param;
            repo = new moviesRepository();
        }

        public bool ValidateData()
        {
            bool valid = true;
            view.errorMessage = null;
            if (repo.Exists(view.movie.title) && view.movie.id == 0)
            {
                view.errorMessage = "Már van ilyen című film létrehozva!";
                valid = false;
            }
            return valid;
        }
    }
}
