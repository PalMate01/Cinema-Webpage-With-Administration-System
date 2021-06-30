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
    public partial class ordersListForm : Form, IDataGridList<orders>
    {
        private ordersListPresenter presenter;
        //jelenlegi oszlop amire kattintva lett
        private int sortIndex;
        //Oldalak száma összesen
        private int pageCount;
        //Összes elem
        private int _totalItems;

        public ordersListForm()
        {
            InitializeComponent();
            presenter = new ordersListPresenter(this);
            Init();
        }

        private void Init()
        {
            page = 1;
            itemsPerPage = 10;
            sortIndex = 0;
            sortBy = "date";
            ascending = true;
        }

        public BindingList<orders> bindingList
        {
            get => (BindingList<orders>)dataGridView1.DataSource;
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

        private void ordersListForm_Load(object sender, EventArgs e)
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
                    sortBy = "customer_id";
                    break;
                case 1:
                    sortBy = "date";
                    break;
                case 2:
                    sortBy = "payment_mode";
                    break;
                default:
                    break;
            }
            sortIndex = e.ColumnIndex;
            presenter.LoadData();
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

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void szerkesztesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void DelDGRow()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void EditDGRow(int index)
        {
            var order = (orders)dataGridView1.Rows[index].DataBoundItem;
            using (var modifyForm = new orderForm())
            {
                modifyForm.order = order;
                DialogResult dr = modifyForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Modify(modifyForm.order);
                    modifyForm.Close();
                }
            }
        }
    }
}
