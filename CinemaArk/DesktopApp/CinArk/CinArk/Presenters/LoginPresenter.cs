using CinArk.Models;
using CinArk.Properties;
using CinArk.Repositores;
using CinArk.Services;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Presenters
{
    public class LoginPresenter
    {
        private usersRepository repo;
        private ILoginView view;

        public LoginPresenter(ILoginView param)
        {
            view = param;
            repo = new usersRepository();
        }

        public bool Login()
        {
            view.errUsername = null;
            view.errPass = null;

            if (string.IsNullOrWhiteSpace(view.username))
            {
                view.errUsername = Resources.KotelezoMezo;
            }

            if (string.IsNullOrWhiteSpace(view.pass))
            {
                view.errPass = Resources.KotelezoMezo;
            }

            //Ha ki van töltve a felhasználónév és a jelszó mező is
            if (!string.IsNullOrWhiteSpace(view.username) && !string.IsNullOrWhiteSpace(view.pass))
            {
                //Létezik e a felhasználó
                if (repo.Exists(view.username))
                {
                    var userid = repo.GetId(view.username);
                    var jelszo = Hash.Encrypt(view.pass);
                    //Jó-e a jelszó a felhasználóhoz
                    if (repo.autentic(view.username, jelszo))
                    {
                        CurrentUser.Id = userid;
                        CurrentUser.username = view.username;
                        return true;
                    }
                    else
                    {
                        view.errPass = Resources.rosszAzonosito;
                    }
                }
                else
                {
                    view.errUsername = string.Format(Resources.FelhasznaloNemLetezik, view.username);
                }
            }

            return false;
        }
    }
}
