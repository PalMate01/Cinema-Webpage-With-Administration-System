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
    public partial class orderForm : Form, IorderView
    {
        private int Id;
        ordersPresenter presenter;
        public orderForm()
        {
            InitializeComponent();
            presenter = new ordersPresenter(this);
        }

        public orders order
        {
            get
            {
                var date = Convert.ToDateTime(dateTextBox.Text);
                var customer_id = Convert.ToInt32(customer_idTextBox.Text);

                var user = new orders(customer_id, date, payment_modeTextBox.Text);

                if (Id > 0)
                {
                    user.id = Id;
                }
                return user;
            }
            set
            {
                customer_idTextBox.Text = value.customer_id.ToString();
                dateTextBox.Text = value.date.ToString();
                payment_modeTextBox.Text = value.payment_mode;
                Id = value.id;
            }
        }

        public string errorMessage
        {
            get => errorPcustomer_id.GetError(customer_idTextBox);
            set => errorPcustomer_id.SetError(customer_idTextBox, value);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void numericValueValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
