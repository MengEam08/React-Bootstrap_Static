namespace My_Store
{
    partial class CategoryForm
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
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mystoresystemDataSet = new My_Store.mystoresystemDataSet();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSlling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new My_Store.mystoresystemDataSetTableAdapters.CategoryTableAdapter();
            this.catDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mystoresystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.DataGridViewCategory);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(180, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 518);
            this.panel1.TabIndex = 21;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.mystoresystemDataSet;
            // 
            // mystoresystemDataSet
            // 
            this.mystoresystemDataSet.DataSetName = "mystoresystemDataSet";
            this.mystoresystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(175, 253);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(164, 37);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 194);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 37);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(175, 136);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 37);
            this.txtID.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(255, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 56);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(138, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 56);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(32, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(11, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 56);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSlling
            // 
            this.btnSlling.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSlling.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnSlling.FlatAppearance.BorderSize = 3;
            this.btnSlling.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlling.Location = new System.Drawing.Point(11, 301);
            this.btnSlling.Name = "btnSlling";
            this.btnSlling.Size = new System.Drawing.Size(133, 56);
            this.btnSlling.TabIndex = 17;
            this.btnSlling.Text = "Selling";
            this.btnSlling.UseVisualStyleBackColor = false;
            this.btnSlling.Click += new System.EventHandler(this.btnSlling_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(11, 174);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(133, 56);
            this.btnProduct.TabIndex = 18;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // catDesDataGridViewTextBoxColumn
            // 
            this.catDesDataGridViewTextBoxColumn.DataPropertyName = "CatDes";
            this.catDesDataGridViewTextBoxColumn.HeaderText = "CatDes";
            this.catDesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catDesDataGridViewTextBoxColumn.Name = "catDesDataGridViewTextBoxColumn";
            this.catDesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "CatName";
            this.catNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            this.catNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "CatId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "CatId";
            this.catIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            this.catIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridViewCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCategory.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCategory.ColumnHeadersHeight = 4;
            this.DataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIdDataGridViewTextBoxColumn,
            this.catNameDataGridViewTextBoxColumn,
            this.catDesDataGridViewTextBoxColumn});
            this.DataGridViewCategory.DataSource = this.categoryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCategory.Location = new System.Drawing.Point(392, 10);
            this.DataGridViewCategory.Name = "DataGridViewCategory";
            this.DataGridViewCategory.ReadOnly = true;
            this.DataGridViewCategory.RowHeadersVisible = false;
            this.DataGridViewCategory.RowHeadersWidth = 51;
            this.DataGridViewCategory.RowTemplate.Height = 24;
            this.DataGridViewCategory.Size = new System.Drawing.Size(593, 498);
            this.DataGridViewCategory.TabIndex = 8;
            this.DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCategory.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewCategory.ThemeStyle.ReadOnly = true;
            this.DataGridViewCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewCategory.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewCategory.Click += new System.EventHandler(this.DataGridViewCategory_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSlling);
            this.Controls.Add(this.btnProduct);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mystoresystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSlling;
        private System.Windows.Forms.Button btnProduct;
        private mystoresystemDataSet mystoresystemDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private mystoresystemDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDesDataGridViewTextBoxColumn;
    }
}