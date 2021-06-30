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
    public partial class itemForm : Form, IitemView
    {
        private int Id;
        itemsPresenter presenter;

        public itemForm()
        {
            InitializeComponent();
            presenter = new itemsPresenter(this);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public items item
        {
            get
            {
                var product_id = Convert.ToInt32(product_idTextBox.Text);
                var quantity = Convert.ToInt32(quantityTextBox.Text);
                var price = Convert.ToInt32(priceTextBox.Text);
                var order_id = Convert.ToInt32(order_idTextBox.Text);
                var customer_id = Convert.ToInt32(customer_idTextBox.Text);
                var room = Convert.ToInt32(roomTextBox.Text);
                var line = Convert.ToInt32(lineTextBox.Text);
                var seat = Convert.ToInt32(seatTextBox.Text);

                var item = new items(product_id, quantity, price, order_id, customer_id, movieTextBox.Text, room, line, seat, monthTextBox.Text, dayTextBox.Text, lectureTextBox.Text);

                if (Id > 0)
                {
                    item.id = Id;
                }
                return item;
            }
            set
            {
                product_idTextBox.Text = value.product_id.ToString();
                quantityTextBox.Text = value.quantity.ToString();
                priceTextBox.Text = value.price.ToString();
                order_idTextBox.Text = value.order_id.ToString();
                customer_idTextBox.Text = value.customer_id.ToString();
                movieTextBox.Text = value.movie;
                roomTextBox.Text = value.room.ToString();
                lineTextBox.Text = value.line.ToString();
                seatTextBox.Text = value.seat.ToString();
                monthTextBox.Text = value.month;
                dayTextBox.Text = value.day;
                lectureTextBox.Text = value.lecture;
                Id = value.id;
            }
        }
        public string errorMessage
        {
            get => errorPorder_id.GetError(order_idTextBox);
            set => errorPorder_id.SetError(order_idTextBox, value);
        }

        

        private void numericValueValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lectureValueValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            // csak 1db kettőspont adható meg 
            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf(':') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
