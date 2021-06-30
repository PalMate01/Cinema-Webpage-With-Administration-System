using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    class usersPresenter
    {
        IuserView view;
        usersRepository repo;
        public usersPresenter(IuserView param)
        {
            view = param;
            repo = new usersRepository();
        }

        public bool ValidateData()
        {
            bool valid = true;
            view.errorMessage = null;
            if (repo.Exists(view.user.username) && view.user.id == 0)
            {
                view.errorMessage = "Már van ilyen felhasználó létrehozva!";
                valid = false;
            }
            return valid;
        }
    }
}
