namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnDelete);
            this.gbxAdd.Controls.Add(this.btnUpdate);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblStockAmountAdd);
            this.gbxAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.lblNameAdd);
            this.gbxAdd.Location = new System.Drawing.Point(915, 121);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(255, 320);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(76, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 44);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 44);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(128, 114);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(100, 22);
            this.tbxStockAmount.TabIndex = 5;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(128, 73);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(128, 26);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 3;
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(13, 119);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(95, 17);
            this.lblStockAmountAdd.TabIndex = 2;
            this.lblStockAmountAdd.Text = "Stock Amount";
            this.lblStockAmountAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(39, 78);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(69, 17);
            this.lblUnitPriceAdd.TabIndex = 1;
            this.lblUnitPriceAdd.Text = "Unit Price";
            this.lblUnitPriceAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(63, 31);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(45, 17);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name";
            this.lblNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 61);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(888, 380);
            this.dgwProducts.TabIndex = 2;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.Location = new System.Drawing.Point(915, 81);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(255, 22);
            this.tbxSearchName.TabIndex = 5;
            this.tbxSearchName.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearchName
            // 
            this.lblSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(912, 61);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(53, 17);
            this.lblSearchName.TabIndex = 6;
            this.lblSearchName.Text = "Search";
            this.lblSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(528, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 57);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.tbxSearchName);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblStockAmountAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxSearchName;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblTitle;
    }
}

