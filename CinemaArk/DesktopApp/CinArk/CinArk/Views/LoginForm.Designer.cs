namespace CinArk.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorPusername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPpass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPpass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(33, 166);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(228, 44);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(26, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(26, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 3;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsernameTextBox.Location = new System.Drawing.Point(47, 226);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(214, 17);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(26, 370);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(235, 35);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOG IN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearLabel.Location = new System.Drawing.Point(157, 337);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(104, 16);
            this.ClearLabel.TabIndex = 6;
            this.ClearLabel.Text = "Mezők ürítése";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitLabel.Location = new System.Drawing.Point(117, 422);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(60, 16);
            this.ExitLabel.TabIndex = 7;
            this.ExitLabel.Text = "Kilépés";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PassTextBox.Location = new System.Drawing.Point(47, 291);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(214, 17);
            this.PassTextBox.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // errorPusername
            // 
            this.errorPusername.ContainerControl = this;
            // 
            // errorPpass
            // 
            this.errorPpass.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorPusername;
        private System.Windows.Forms.ErrorProvider errorPpass;
    }
}