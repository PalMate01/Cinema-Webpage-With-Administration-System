using CinArk.Models;
using CinArk.Presenters;
using CinArk.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinArk.Views
{
    public partial class userForm : Form, IuserView
    {
        private int Id;
        usersPresenter presenter;
        public userForm()
        {
            InitializeComponent();
            presenter = new usersPresenter(this);
        }

        public user user
        {
            get
            {
                var join_date = Convert.ToDateTime(join_dateTextBox.Text);

                var user = new user(usernameTextBox.Text, pwdTextBox.Text, nameTextBox.Text, emailTextBox.Text, home_addressTextBox.Text, join_date);

                if (Id > 0)
                {
                    user.id = Id;
                }
                return user;
            }
            set
            {
                usernameTextBox.Text = value.username;
                pwdTextBox.Text = value.pwd;
                nameTextBox.Text = value.name;
                emailTextBox.Text = value.email;
                home_addressTextBox.Text = value.home_address;
                join_dateTextBox.Text = value.join_date.ToString();
                Id = value.id;
            }
        }
        public string errorMessage
        {
            get => errorPusername.GetError(usernameTextBox);
            set => errorPusername.SetError(usernameTextBox, value);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
