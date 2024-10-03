namespace Stock
{
    partial class Stock
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDateTimePicker1 = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotalQuantities = new System.Windows.Forms.Label();
            this.lblTPResults = new System.Windows.Forms.Label();
            this.lblTQResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(259, 63);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(379, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.txtQuantity.Location = new System.Drawing.Point(495, 63);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(619, 63);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblDateTimePicker1
            // 
            this.lblDateTimePicker1.AutoSize = true;
            this.lblDateTimePicker1.Location = new System.Drawing.Point(24, 45);
            this.lblDateTimePicker1.Name = "lblDateTimePicker1";
            this.lblDateTimePicker1.Size = new System.Drawing.Size(30, 13);
            this.lblDateTimePicker1.TabIndex = 5;
            this.lblDateTimePicker1.Text = "Date";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(256, 45);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 6;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(492, 45);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(616, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(376, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Product Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgProCode,
            this.dgProName,
            this.dgQuantity,
            this.dgDate,
            this.dgStatus});
            this.dgvStock.Location = new System.Drawing.Point(130, 134);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(640, 150);
            this.dgvStock.TabIndex = 13;
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "SNo";
            this.dgSno.Name = "dgSno";
            // 
            // dgProCode
            // 
            this.dgProCode.HeaderText = "Product Code";
            this.dgProCode.Name = "dgProCode";
            // 
            // dgProName
            // 
            this.dgProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgProName.HeaderText = "Product Name";
            this.dgProName.Name = "dgProName";
            // 
            // dgQuantity
            // 
            this.dgQuantity.HeaderText = "Quantity";
            this.dgQuantity.Name = "dgQuantity";
            // 
            // dgDate
            // 
            this.dgDate.HeaderText = "Date";
            this.dgDate.Name = "dgDate";
            // 
            // dgStatus
            // 
            this.dgStatus.HeaderText = "Status";
            this.dgStatus.Name = "dgStatus";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new System.Drawing.Point(106, 358);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(79, 13);
            this.lblTotalProducts.TabIndex = 14;
            this.lblTotalProducts.Text = "Total Products:";
            // 
            // lblTotalQuantities
            // 
            this.lblTotalQuantities.AutoSize = true;
            this.lblTotalQuantities.Location = new System.Drawing.Point(106, 384);
            this.lblTotalQuantities.Name = "lblTotalQuantities";
            this.lblTotalQuantities.Size = new System.Drawing.Size(84, 13);
            this.lblTotalQuantities.TabIndex = 15;
            this.lblTotalQuantities.Text = "Total Quantities:";
            // 
            // lblTPResults
            // 
            this.lblTPResults.AutoSize = true;
            this.lblTPResults.Location = new System.Drawing.Point(191, 358);
            this.lblTPResults.Name = "lblTPResults";
            this.lblTPResults.Size = new System.Drawing.Size(13, 13);
            this.lblTPResults.TabIndex = 16;
            this.lblTPResults.Text = "0";
            // 
            // lblTQResult
            // 
            this.lblTQResult.AutoSize = true;
            this.lblTQResult.Location = new System.Drawing.Point(191, 384);
            this.lblTQResult.Name = "lblTQResult";
            this.lblTQResult.Size = new System.Drawing.Size(13, 13);
            this.lblTQResult.TabIndex = 17;
            this.lblTQResult.Text = "0";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTQResult);
            this.Controls.Add(this.lblTPResults);
            this.Controls.Add(this.lblTotalQuantities);
            this.Controls.Add(this.lblTotalProducts);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblDateTimePicker1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDateTimePicker1;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTotalQuantities;
        private System.Windows.Forms.Label lblTPResults;
        private System.Windows.Forms.Label lblTQResult;
    }
}