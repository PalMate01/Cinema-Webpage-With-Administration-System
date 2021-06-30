namespace CinArk.Views
{
    partial class moviesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.Lenghtlabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.ImgLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.RoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorPtitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateTextBox = new System.Windows.Forms.TextBox();
            this.ImgPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImgButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPtitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(260, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 34);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Mégse";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(439, 340);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 34);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 16);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Cím";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenreLabel.Location = new System.Drawing.Point(18, 69);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(45, 16);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Műfaj";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RatingLabel.Location = new System.Drawing.Point(18, 116);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(74, 16);
            this.RatingLabel.TabIndex = 4;
            this.RatingLabel.Text = "Értékelés";
            // 
            // Lenghtlabel
            // 
            this.Lenghtlabel.AutoSize = true;
            this.Lenghtlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lenghtlabel.Location = new System.Drawing.Point(21, 165);
            this.Lenghtlabel.Name = "Lenghtlabel";
            this.Lenghtlabel.Size = new System.Drawing.Size(51, 16);
            this.Lenghtlabel.TabIndex = 5;
            this.Lenghtlabel.Text = "Hossz";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReleaseDateLabel.Location = new System.Drawing.Point(21, 215);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(89, 16);
            this.ReleaseDateLabel.TabIndex = 6;
            this.ReleaseDateLabel.Text = "Megjelenés";
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoomLabel.Location = new System.Drawing.Point(21, 265);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(53, 16);
            this.RoomLabel.TabIndex = 7;
            this.RoomLabel.Text = "Terem";
            // 
            // ImgLabel
            // 
            this.ImgLabel.AutoSize = true;
            this.ImgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImgLabel.Location = new System.Drawing.Point(18, 317);
            this.ImgLabel.Name = "ImgLabel";
            this.ImgLabel.Size = new System.Drawing.Size(49, 16);
            this.ImgLabel.TabIndex = 8;
            this.ImgLabel.Text = "Borító";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Location = new System.Drawing.Point(69, 16);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(163, 24);
            this.TitleTextBox.TabIndex = 9;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreTextBox.Location = new System.Drawing.Point(69, 69);
            this.GenreTextBox.Multiline = true;
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(163, 24);
            this.GenreTextBox.TabIndex = 10;
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LenghtTextBox.Location = new System.Drawing.Point(116, 165);
            this.LenghtTextBox.Multiline = true;
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(116, 24);
            this.LenghtTextBox.TabIndex = 11;
            // 
            // RoomNumericUpDown
            // 
            this.RoomNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomNumericUpDown.Location = new System.Drawing.Point(116, 265);
            this.RoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomNumericUpDown.Name = "RoomNumericUpDown";
            this.RoomNumericUpDown.Size = new System.Drawing.Size(116, 16);
            this.RoomNumericUpDown.TabIndex = 14;
            this.RoomNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorPtitle
            // 
            this.errorPtitle.ContainerControl = this;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatingTextBox.Location = new System.Drawing.Point(116, 116);
            this.RatingTextBox.Multiline = true;
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(116, 24);
            this.RatingTextBox.TabIndex = 15;
            this.RatingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratingValueValidation);
            // 
            // ReleaseDateTextBox
            // 
            this.ReleaseDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReleaseDateTextBox.Location = new System.Drawing.Point(116, 215);
            this.ReleaseDateTextBox.Multiline = true;
            this.ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            this.ReleaseDateTextBox.Size = new System.Drawing.Size(116, 24);
            this.ReleaseDateTextBox.TabIndex = 16;
            this.ReleaseDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueValidation);
            // 
            // ImgPictureBox
            // 
            this.ImgPictureBox.Location = new System.Drawing.Point(260, 16);
            this.ImgPictureBox.Name = "ImgPictureBox";
            this.ImgPictureBox.Size = new System.Drawing.Size(254, 274);
            this.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPictureBox.TabIndex = 17;
            this.ImgPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImgButton
            // 
            this.ImgButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImgButton.ForeColor = System.Drawing.Color.White;
            this.ImgButton.Location = new System.Drawing.Point(16, 340);
            this.ImgButton.Name = "ImgButton";
            this.ImgButton.Size = new System.Drawing.Size(84, 34);
            this.ImgButton.TabIndex = 19;
            this.ImgButton.Text = "Tallózás..";
            this.ImgButton.UseVisualStyleBackColor = false;
            this.ImgButton.Click += new System.EventHandler(this.ImgButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(21, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 1);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(21, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(21, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 1);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(21, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 1);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(21, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 1);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(21, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 1);
            this.panel6.TabIndex = 23;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 390);
            this.panel13.TabIndex = 92;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Location = new System.Drawing.Point(521, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 390);
            this.panel7.TabIndex = 93;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel8.Location = new System.Drawing.Point(10, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(518, 10);
            this.panel8.TabIndex = 93;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel9.Location = new System.Drawing.Point(10, 380);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(518, 10);
            this.panel9.TabIndex = 94;
            // 
            // moviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(530, 390);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ImgButton);
            this.Controls.Add(this.ImgPictureBox);
            this.Controls.Add(this.ReleaseDateTextBox);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RoomNumericUpDown);
            this.Controls.Add(this.LenghtTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ImgLabel);
            this.Controls.Add(this.RoomLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.Lenghtlabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "moviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmek";
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPtitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label Lenghtlabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.Label ImgLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.NumericUpDown RoomNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorPtitle;
        private System.Windows.Forms.TextBox ReleaseDateTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.PictureBox ImgPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ImgButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}