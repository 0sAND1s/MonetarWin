namespace MonetarWin
{
    partial class ControlCurrency
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sumCurrentLabel;
            System.Windows.Forms.Label sumPrevLabel;
            System.Windows.Forms.Label remainingLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAmounts = new System.Windows.Forms.DataGridView();
            this.sumCurrentTextBox = new System.Windows.Forms.TextBox();
            this.sumPrevTextBox = new System.Windows.Forms.TextBox();
            this.remainingTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyDenomAmountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PieceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sumCurrentLabel = new System.Windows.Forms.Label();
            sumPrevLabel = new System.Windows.Forms.Label();
            remainingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAmounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDenomAmountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sumCurrentLabel
            // 
            sumCurrentLabel.AutoSize = true;
            sumCurrentLabel.Location = new System.Drawing.Point(4, 257);
            sumCurrentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sumCurrentLabel.Name = "sumCurrentLabel";
            sumCurrentLabel.Size = new System.Drawing.Size(111, 17);
            sumCurrentLabel.TabIndex = 2;
            sumCurrentLabel.Text = "Total efectiv (1):";
            // 
            // sumPrevLabel
            // 
            sumPrevLabel.AutoSize = true;
            sumPrevLabel.Location = new System.Drawing.Point(4, 289);
            sumPrevLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sumPrevLabel.Name = "sumPrevLabel";
            sumPrevLabel.Size = new System.Drawing.Size(127, 17);
            sumPrevLabel.TabIndex = 4;
            sumPrevLabel.Text = "Sold calculator (2):";
            // 
            // remainingLabel
            // 
            remainingLabel.AutoSize = true;
            remainingLabel.Location = new System.Drawing.Point(4, 314);
            remainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new System.Drawing.Size(123, 17);
            remainingLabel.TabIndex = 6;
            remainingLabel.Text = "Diferența (1) - (2):";
            // 
            // gridAmounts
            // 
            this.gridAmounts.AllowUserToAddRows = false;
            this.gridAmounts.AllowUserToDeleteRows = false;
            this.gridAmounts.AutoGenerateColumns = false;
            this.gridAmounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAmounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAmounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAmounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PieceCount,
            this.denomValueDataGridViewTextBoxColumn,
            this.totalValueDataGridViewTextBoxColumn});
            this.gridAmounts.DataSource = this.currencyDenomAmountBindingSource;
            this.gridAmounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridAmounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridAmounts.Location = new System.Drawing.Point(0, 23);
            this.gridAmounts.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gridAmounts.Name = "gridAmounts";
            this.gridAmounts.RowHeadersVisible = false;
            this.gridAmounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAmounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridAmounts.Size = new System.Drawing.Size(253, 227);
            this.gridAmounts.StandardTab = true;
            this.gridAmounts.TabIndex = 1;
            this.gridAmounts.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridAmounts_CellValidating);
            // 
            // sumCurrentTextBox
            // 
            this.sumCurrentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumCurrentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "SumCurrent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.sumCurrentTextBox.Location = new System.Drawing.Point(140, 254);
            this.sumCurrentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sumCurrentTextBox.Name = "sumCurrentTextBox";
            this.sumCurrentTextBox.ReadOnly = true;
            this.sumCurrentTextBox.Size = new System.Drawing.Size(108, 22);
            this.sumCurrentTextBox.TabIndex = 3;
            this.sumCurrentTextBox.TabStop = false;
            this.sumCurrentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sumPrevTextBox
            // 
            this.sumPrevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "SumPrev", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sumPrevTextBox.Location = new System.Drawing.Point(140, 284);
            this.sumPrevTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sumPrevTextBox.MaxLength = 9;
            this.sumPrevTextBox.Name = "sumPrevTextBox";
            this.sumPrevTextBox.Size = new System.Drawing.Size(108, 22);
            this.sumPrevTextBox.TabIndex = 5;
            this.sumPrevTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // remainingTextBox
            // 
            this.remainingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "Remaining", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.remainingTextBox.Location = new System.Drawing.Point(140, 311);
            this.remainingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remainingTextBox.Name = "remainingTextBox";
            this.remainingTextBox.ReadOnly = true;
            this.remainingTextBox.Size = new System.Drawing.Size(108, 22);
            this.remainingTextBox.TabIndex = 7;
            this.remainingTextBox.TabStop = false;
            this.remainingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "Description", true));
            this.descriptionLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(253, 23);
            this.descriptionLabel1.TabIndex = 0;
            this.descriptionLabel1.Text = "Descriere monedă";
            this.descriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(MonetarWin.Currency);
            // 
            // currencyDenomAmountBindingSource
            // 
            this.currencyDenomAmountBindingSource.AllowNew = false;
            this.currencyDenomAmountBindingSource.DataSource = typeof(MonetarWin.CurrencyDenomAmount);
            // 
            // PieceCount
            // 
            this.PieceCount.DataPropertyName = "PieceCount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.Format = "N0";
            this.PieceCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.PieceCount.FillWeight = 25.38071F;
            this.PieceCount.HeaderText = "Bucăți";
            this.PieceCount.MaxInputLength = 4;
            this.PieceCount.Name = "PieceCount";
            // 
            // denomValueDataGridViewTextBoxColumn
            // 
            this.denomValueDataGridViewTextBoxColumn.DataPropertyName = "DenomName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.denomValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.denomValueDataGridViewTextBoxColumn.FillWeight = 37.30965F;
            this.denomValueDataGridViewTextBoxColumn.HeaderText = "Monedă";
            this.denomValueDataGridViewTextBoxColumn.Name = "denomValueDataGridViewTextBoxColumn";
            this.denomValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            this.totalValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValueDenom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.totalValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalValueDataGridViewTextBoxColumn.FillWeight = 37.30965F;
            this.totalValueDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            this.totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ControlCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(remainingLabel);
            this.Controls.Add(this.sumCurrentTextBox);
            this.Controls.Add(sumPrevLabel);
            this.Controls.Add(sumCurrentLabel);
            this.Controls.Add(this.gridAmounts);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.sumPrevTextBox);
            this.Controls.Add(this.remainingTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlCurrency";
            this.Size = new System.Drawing.Size(253, 344);
            this.Load += new System.EventHandler(this.UCCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAmounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDenomAmountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAmounts;
        private System.Windows.Forms.BindingSource currencyDenomAmountBindingSource;        
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.TextBox sumCurrentTextBox;
        private System.Windows.Forms.TextBox sumPrevTextBox;
        private System.Windows.Forms.TextBox remainingTextBox;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
    }
}
