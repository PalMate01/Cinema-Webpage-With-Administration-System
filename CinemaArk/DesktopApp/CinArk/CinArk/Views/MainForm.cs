using CinArk.Services;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Bejelentkezve: " + CurrentUser.username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void musoronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new movieListForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OsszFelhasznaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new usersListForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tetelekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new itemsListForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void foglalasokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ordersListForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void felhasználóiÜzenetekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new contactListForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
