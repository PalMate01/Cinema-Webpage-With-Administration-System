namespace CinArk.Views
{
    partial class orderForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.payment_modeTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.payment_modeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.customer_idLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorPcustomer_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorPcustomer_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(22, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 1);
            this.panel3.TabIndex = 70;
            // 
            // payment_modeTextBox
            // 
            this.payment_modeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payment_modeTextBox.Location = new System.Drawing.Point(185, 112);
            this.payment_modeTextBox.Multiline = true;
            this.payment_modeTextBox.Name = "payment_modeTextBox";
            this.payment_modeTextBox.Size = new System.Drawing.Size(163, 24);
            this.payment_modeTextBox.TabIndex = 62;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Location = new System.Drawing.Point(185, 65);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(163, 24);
            this.dateTextBox.TabIndex = 60;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_idTextBox.Location = new System.Drawing.Point(185, 12);
            this.customer_idTextBox.Multiline = true;
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(163, 24);
            this.customer_idTextBox.TabIndex = 59;
            this.customer_idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueValidation);
            // 
            // payment_modeLabel
            // 
            this.payment_modeLabel.AutoSize = true;
            this.payment_modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.payment_modeLabel.Location = new System.Drawing.Point(16, 112);
            this.payment_modeLabel.Name = "payment_modeLabel";
            this.payment_modeLabel.Size = new System.Drawing.Size(91, 16);
            this.payment_modeLabel.TabIndex = 57;
            this.payment_modeLabel.Text = "fizetési mód";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Location = new System.Drawing.Point(16, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(130, 16);
            this.dateLabel.TabIndex = 56;
            this.dateLabel.Text = "Rendelés dátuma";
            // 
            // customer_idLabel
            // 
            this.customer_idLabel.AutoSize = true;
            this.customer_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customer_idLabel.Location = new System.Drawing.Point(16, 12);
            this.customer_idLabel.Name = "customer_idLabel";
            this.customer_idLabel.Size = new System.Drawing.Size(163, 16);
            this.customer_idLabel.TabIndex = 55;
            this.customer_idLabel.Text = "Felhasználó azonosító";
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(273, 166);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 34);
            this.OkButton.TabIndex = 54;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(21, 166);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 34);
            this.CancelButton.TabIndex = 53;
            this.CancelButton.Text = "Mégse";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(22, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(22, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 1);
            this.panel2.TabIndex = 71;
            // 
            // errorPcustomer_id
            // 
            this.errorPcustomer_id.ContainerControl = this;
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel17.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel17.Location = new System.Drawing.Point(0, -1);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(10, 218);
            this.panel17.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Location = new System.Drawing.Point(354, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 218);
            this.panel4.TabIndex = 94;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Location = new System.Drawing.Point(3, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 10);
            this.panel5.TabIndex = 95;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel6.Location = new System.Drawing.Point(2, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 10);
            this.panel6.TabIndex = 96;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(363, 216);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.payment_modeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(this.payment_modeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.customer_idLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorPcustomer_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox payment_modeTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.Label payment_modeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label customer_idLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorPcustomer_id;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}