using CinArk.Repositores;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    class itemsPresenter
    {
        IitemView view;
        itemsRepository repo;
        public itemsPresenter(IitemView param)
        {
            view = param;
            repo = new itemsRepository();
        }

        public bool ValidateData()
        {
            bool valid = true;
            view.errorMessage = null;
            if (repo.Exists(view.item.customer_id) && view.item.id == 0)
            {
                view.errorMessage = "Már van ilyen tétel létrehozva!";
                valid = false;
            }
            return valid;
        }
    }
}
