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
    public partial class movieListForm : Form, IDataGridList<movies>
    {
        private moviesListPresenter presenter;
        //jelenlegi oszlop amire kattintva lett
        private int sortIndex;
        //Oldalak száma összesen
        private int pageCount;
        //Összes elem
        private int _totalItems;

        public movieListForm()
        {
            InitializeComponent();
            presenter = new moviesListPresenter(this);
            Init();
        }

        //Kezdeti értékek beállítása
        private void Init()
        {
            page = 1;
            itemsPerPage = 10;
            sortIndex = 0;
            sortBy = "title";
            ascending = true;
        }

        public BindingList<movies> bindingList
        {
            get => (BindingList<movies>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        public string search => SearchFieldToolStripTextBox.Text;

        public string sortBy{get ; set;}
        public bool ascending { get; set; }
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public int totalItems {
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

        private void movieListForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
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
                    sortBy = "title";
                    break;
                case 1:
                    sortBy = "genre";
                    break;
                case 2:
                    sortBy = "rating";
                    break;
                case 3:
                    sortBy = "lenght";
                    break;
                case 4:
                    sortBy = "release_date";
                    break;
                case 5:
                    sortBy = "room";
                    break;
                default:
                    break;
            }
            sortIndex = e.ColumnIndex;
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

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            MessageBox.Show("Adatok rögzítve.");
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }


        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                //Több cella kijelölés esetén
                var rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                //több elem kijelölése esetén
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
                var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                EditDGRow(selectedRowIndex);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void DelDGRow()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void NewDGRow()
        {
            using (var modifyForm = new moviesForm())
            {
                DialogResult dr = modifyForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(modifyForm.movie);
                    modifyForm.Close();
                }
            }
        }

        private void EditDGRow(int index)
        {
            var movie = (movies)dataGridView1.Rows[index].DataBoundItem;
            using (var modifyForm = new moviesForm())
            {
                modifyForm.movie = movie;
                DialogResult dr = modifyForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Modify(modifyForm.movie);
                    modifyForm.Close();
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    MessageBox.Show(Resources.szamErteket, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
    }
}
