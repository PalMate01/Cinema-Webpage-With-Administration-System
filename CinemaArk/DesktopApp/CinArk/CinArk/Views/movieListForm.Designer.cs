namespace CinArk.Views
{
    partial class movieListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchFieldToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.moviesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(637, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cím";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Műfaj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn4.HeaderText = "Értékelés";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lenght";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hossz";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "release_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Megjelenés";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "room";
            this.dataGridViewTextBoxColumn7.HeaderText = "Terem";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "img";
            this.dataGridViewImageColumn1.HeaderText = "Borító";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesToolStripMenuItem,
            this.torlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztesToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.torlesToolStripMenuItem.Text = "Törlés";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataSource = typeof(CinArk.Models.movies);
            this.moviesBindingSource.CurrentChanged += new System.EventHandler(this.movieListForm_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.SaveToolStripButton,
            this.DeleteToolStripButton,
            this.SearchFieldToolStripTextBox,
            this.SearchToolStripButton,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewToolStripButton.ForeColor = System.Drawing.Color.White;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.NewToolStripButton.Text = "Új";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveToolStripButton.ForeColor = System.Drawing.Color.White;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.SaveToolStripButton.Text = "Mentés";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteToolStripButton.ForeColor = System.Drawing.Color.White;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.DeleteToolStripButton.Text = "Törlés";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // SearchFieldToolStripTextBox
            // 
            this.SearchFieldToolStripTextBox.Name = "SearchFieldToolStripTextBox";
            this.SearchFieldToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // SearchToolStripButton
            // 
            this.SearchToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchToolStripButton.ForeColor = System.Drawing.Color.White;
            this.SearchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchToolStripButton.Image")));
            this.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchToolStripButton.Name = "SearchToolStripButton";
            this.SearchToolStripButton.Size = new System.Drawing.Size(74, 22);
            this.SearchToolStripButton.Text = "Keresés";
            this.SearchToolStripButton.Click += new System.EventHandler(this.SearchToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel1.Text = "(cím alapján)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PageLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalItemsLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 324);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 56);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastButton.ForeColor = System.Drawing.Color.White;
            this.LastButton.Location = new System.Drawing.Point(486, 16);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = false;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(390, 16);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PageLabel.Location = new System.Drawing.Point(319, 20);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(27, 15);
            this.PageLabel.TabIndex = 4;
            this.PageLabel.Text = "1/1";
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrevButton.ForeColor = System.Drawing.Color.White;
            this.PrevButton.Location = new System.Drawing.Point(200, 16);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstButton.ForeColor = System.Drawing.Color.White;
            this.FirstButton.Location = new System.Drawing.Point(105, 16);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalItemsLabel.Location = new System.Drawing.Point(11, 20);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(73, 15);
            this.TotalItemsLabel.TabIndex = 5;
            this.TotalItemsLabel.Text = "Összesen:";
            // 
            // movieListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movieListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Műsoron";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.movieListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripTextBox SearchFieldToolStripTextBox;
        private System.Windows.Forms.ToolStripButton SearchToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}