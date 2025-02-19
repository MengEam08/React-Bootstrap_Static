namespace My_Store
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_seller = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.DataGridViewProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DataGridViewSell = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DataGridViewOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.Location = new System.Drawing.Point(41, 15);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(95, 29);
            this.label_seller.TabIndex = 28;
            this.label_seller.Text = "Selling";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtBill);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.DataGridViewProduct);
            this.panel1.Controls.Add(this.DataGridViewSell);
            this.panel1.Controls.Add(this.DataGridViewOrder);
            this.panel1.Controls.Add(this.txtQuanity);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(178, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 593);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(684, 278);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(92, 37);
            this.txtBill.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(615, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bill ID";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(736, 10);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(63, 29);
            this.label_Date.TabIndex = 28;
            this.label_Date.Text = "Date";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(42, 284);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(161, 24);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.Text = "Select Category";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // DataGridViewProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduct.Location = new System.Drawing.Point(21, 316);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.ReadOnly = true;
            this.DataGridViewProduct.RowHeadersVisible = false;
            this.DataGridViewProduct.RowHeadersWidth = 51;
            this.DataGridViewProduct.RowTemplate.Height = 24;
            this.DataGridViewProduct.Size = new System.Drawing.Size(313, 273);
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
            this.DataGridViewProduct.Click += new System.EventHandler(this.DataGridViewProduct_Click_1);
            // 
            // DataGridViewSell
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewSell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewSell.ColumnHeadersHeight = 4;
            this.DataGridViewSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSell.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewSell.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSell.Location = new System.Drawing.Point(409, 316);
            this.DataGridViewSell.Name = "DataGridViewSell";
            this.DataGridViewSell.ReadOnly = true;
            this.DataGridViewSell.RowHeadersVisible = false;
            this.DataGridViewSell.RowHeadersWidth = 51;
            this.DataGridViewSell.RowTemplate.Height = 24;
            this.DataGridViewSell.Size = new System.Drawing.Size(472, 272);
            this.DataGridViewSell.TabIndex = 8;
            this.DataGridViewSell.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSell.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewSell.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSell.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewSell.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSell.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSell.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSell.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewSell.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewSell.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSell.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewSell.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewSell.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewSell.ThemeStyle.ReadOnly = true;
            this.DataGridViewSell.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSell.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSell.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSell.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewSell.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewSell.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSell.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DataGridViewOrder
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewOrder.ColumnHeadersHeight = 4;
            this.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder.Location = new System.Drawing.Point(409, 45);
            this.DataGridViewOrder.Name = "DataGridViewOrder";
            this.DataGridViewOrder.ReadOnly = true;
            this.DataGridViewOrder.RowHeadersVisible = false;
            this.DataGridViewOrder.RowHeadersWidth = 51;
            this.DataGridViewOrder.RowTemplate.Height = 24;
            this.DataGridViewOrder.Size = new System.Drawing.Size(472, 169);
            this.DataGridViewOrder.TabIndex = 8;
            this.DataGridViewOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewOrder.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewOrder.ThemeStyle.ReadOnly = true;
            this.DataGridViewOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewOrder.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(97, 155);
            this.txtQuanity.Multiline = true;
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(164, 37);
            this.txtQuanity.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 106);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 37);
            this.txtPrice.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 57);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 37);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(816, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(282, 105);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(76, 40);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(236, 276);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 40);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 1;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(510, 228);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(75, 23);
            this.label_amount.TabIndex = 1;
            this.label_amount.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quanity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sell List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(11, 451);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 56);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(11, 317);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(133, 56);
            this.btnProduct.TabIndex = 29;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(11, 174);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(133, 56);
            this.btnCategory.TabIndex = 30;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.label_seller);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewOrder;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProduct;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewSell;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCategory;
    }
}