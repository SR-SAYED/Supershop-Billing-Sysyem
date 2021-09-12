namespace BillingSystem.UI
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 41);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1069, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(492, 9);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(154, 28);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "TRANSACTIONS";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(17, 135);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.Size = new System.Drawing.Size(1092, 417);
            this.dgvTransactions.TabIndex = 3;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(16, 86);
            this.lblTransactionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(110, 19);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.cmbTransactionType.Location = new System.Drawing.Point(151, 83);
            this.cmbTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(411, 25);
            this.cmbTransactionType.TabIndex = 5;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(570, 80);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(137, 33);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(741, 86);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 19);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(788, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 25);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(886, 86);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 19);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(915, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 25);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1007, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Show";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1125, 567);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSearch;
    }
}