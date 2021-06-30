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
    public partial class contactListForm : Form, IDataGridList<contact>
    {
        private contactListPresenter presenter;
        //jelenlegi oszlop amire kattintva lett
        private int sortIndex;
        //Oldalak száma összesen
        private int pageCount;
        //Összes elem
        private int _totalItems;
        public contactListForm()
        {
            InitializeComponent();
            presenter = new contactListPresenter(this);
            Init();
        }

        private void Init()
        {
            page = 1;
            itemsPerPage = 10;
            sortIndex = 0;
            sortBy = "name_id";
            ascending = true;
        }

        //Adatbázis
        public BindingList<contact> bindingList
        {
            get => (BindingList<contact>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }


        public string search => SearchFieldToolStripTextBox.Text;

        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public int totalItems
        {
            get
            {
                return _totalItems;
            }
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                PageLabel.Text = page.ToString() + "/" + pageCount;
                TotalItemsLabel.Text = "Összesen: " + value;
                _totalItems = value;
            }
        }


        private void contactListForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();

        }

        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (page < pageCount)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            page = pageCount;
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                case 0:
                    sortBy = "name_id";
                    break;
                case 1:
                    sortBy = "message";
                    break;
                default:
                    break;
            }
            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            MessageBox.Show("Adatok rögzítve.");
        }

        private void DelDGRow()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
