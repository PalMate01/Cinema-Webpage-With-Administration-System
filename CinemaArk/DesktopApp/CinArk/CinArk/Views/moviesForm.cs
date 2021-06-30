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
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing.Drawing2D;

namespace CinArk.Views
{
    public partial class moviesForm : Form, ImoviesView
    {
        byte[] GetImg = null;
        private int Id;
        moviesPresenter presenter;

        public moviesForm()
        {
            InitializeComponent();
            presenter = new moviesPresenter(this);
        }

        public movies movie
        {
            get
            {
                
                var room = Convert.ToInt32(RoomNumericUpDown.Value);
                
                var movie = new movies(TitleTextBox.Text, GenreTextBox.Text, RatingTextBox.Text, LenghtTextBox.Text, ReleaseDateTextBox.Text, room, GetImg);
                //
                if (Id > 0)
                {
                    movie.id = Id;
                }
                return movie;
            }
            set
            {
                TitleTextBox.Text = value.title;
                GenreTextBox.Text = value.genre;
                RatingTextBox.Text = value.rating;
                LenghtTextBox.Text = value.lenght;
                ReleaseDateTextBox.Text = value.release_date;
                RoomNumericUpDown.Value = value.room;
                GetImg = value.img;
                Id = value.id;

            }
        }
        public string errorMessage
        {
            get => errorPtitle.GetError(TitleTextBox);
            set => errorPtitle.SetError(TitleTextBox, value);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ImgButton_Click(object sender, EventArgs e)
        {
            Img();
        }
        
        //kép kiválasztása, átalakítás byte[]-re
        public void Img()
        {
            string imageLocation;
            
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog1.FileName;
                    ImgPictureBox.ImageLocation = imageLocation;
                    FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fs);
                    GetImg = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Váratlan hiba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //szám validáció
        private void numericValueValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //szám validáció '.' karakterrel a decimális érték miatt
        private void ratingValueValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // csak 1db pont adható meg
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
