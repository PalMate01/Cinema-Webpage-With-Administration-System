using CinArk.Models;
using CinArk.Presenters;
using CinArk.Properties;
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
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;

        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string username => UsernameTextBox.Text;

        public string pass => PassTextBox.Text;

        public string errUsername { set => errorPusername.SetError(UsernameTextBox, value); }
        public string errPass { set => errorPpass.SetError(PassTextBox, value); }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (presenter.Login() == true)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PassTextBox.Clear();
            UsernameTextBox.Focus();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = LoginButton;
        }
    }
}
