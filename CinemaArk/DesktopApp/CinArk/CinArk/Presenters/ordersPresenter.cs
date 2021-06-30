using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    class ordersPresenter
    {
        IorderView view;
        ordersRepository repo;
        public ordersPresenter(IorderView param)
        {
            view = param;
            repo = new ordersRepository();
        }

        public bool ValidateData()
        {
            bool valid = true;
            view.errorMessage = null;
            if (repo.Exists(view.order.id) && view.order.id == 0)
            {
                view.errorMessage = "Már van ilyen megrendelés!";
                valid = false;
            }
            return valid;
        }
    }
}
