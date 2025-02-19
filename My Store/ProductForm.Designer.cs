namespace My_Store
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridViewProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mystoresystemDataSet = new My_Store.mystoresystemDataSet();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSlling = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.productTableAdapter = new My_Store.mystoresystemDataSetTableAdapters.ProductTableAdapter();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mystoresystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.DataGridViewProduct);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(178, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 518);
            this.panel1.TabIndex = 13;
            // 
            // DataGridViewProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewProduct.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewProduct.ColumnHeadersHeight = 4;
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodQtyDataGridViewTextBoxColumn,
            this.prodCatDataGridViewTextBoxColumn});
            this.DataGridViewProduct.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduct.Location = new System.Drawing.Point(413, 11);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.ReadOnly = true;
            this.DataGridViewProduct.RowHeadersVisible = false;
            this.DataGridViewProduct.RowHeadersWidth = 51;
            this.DataGridViewProduct.RowTemplate.Height = 24;
            this.DataGridViewProduct.Size = new System.Drawing.Size(572, 498);
            this.DataGridViewProduct.TabIndex = 8;
            this.DataGridViewProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewProduct.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewProduct.ThemeStyle.ReadOnly = true;
            this.DataGridViewProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewProduct.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewProduct.Click += new System.EventHandler(this.DataGridViewProduct_Click);
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "ProdId";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "ProdId";
            this.prodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodQtyDataGridViewTextBoxColumn
            // 
            this.prodQtyDataGridViewTextBoxColumn.DataPropertyName = "ProdQty";
            this.prodQtyDataGridViewTextBoxColumn.HeaderText = "ProdQty";
            this.prodQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQtyDataGridViewTextBoxColumn.Name = "prodQtyDataGridViewTextBoxColumn";
            this.prodQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodCatDataGridViewTextBoxColumn
            // 
            this.prodCatDataGridViewTextBoxColumn.DataPropertyName = "ProdCat";
            this.prodCatDataGridViewTextBoxColumn.HeaderText = "ProdCat";
            this.prodCatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodCatDataGridViewTextBoxColumn.Name = "prodCatDataGridViewTextBoxColumn";
            this.prodCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mystoresystemDataSet;
            // 
            // mystoresystemDataSet
            // 
            this.mystoresystemDataSet.DataSetName = "mystoresystemDataSet";
            this.mystoresystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(126, 324);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(164, 24);
            this.cmbCategory.TabIndex = 7;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(126, 253);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(164, 37);
            this.txtQty.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(126, 196);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 37);
            this.txtPrice.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 137);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 37);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 79);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 37);
            this.txtID.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(272, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 56);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(141, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 56);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quanity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // btnSlling
            // 
            this.btnSlling.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSlling.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnSlling.FlatAppearance.BorderSize = 3;
            this.btnSlling.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlling.Location = new System.Drawing.Point(11, 265);
            this.btnSlling.Name = "btnSlling";
            this.btnSlling.Size = new System.Drawing.Size(133, 56);
            this.btnSlling.TabIndex = 9;
            this.btnSlling.Text = "Selling";
            this.btnSlling.UseVisualStyleBackColor = false;
            this.btnSlling.Click += new System.EventHandler(this.btnSlling_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(11, 138);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(133, 56);
            this.btnCategory.TabIndex = 10;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(917, 36);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(164, 24);
            this.cmbSearch.TabIndex = 26;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1087, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 30);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(11, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 56);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSlling);
            this.Controls.Add(this.btnCategory);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mystoresystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSlling;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private mystoresystemDataSet mystoresystemDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private mystoresystemDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLogout;
    }
}