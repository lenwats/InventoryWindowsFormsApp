
namespace InventoryWindowsFormsApp.Views
{
    partial class MainScreen
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
            this.labelMainScreenTitle = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.labelDataGridVewPartsTitle = new System.Windows.Forms.Label();
            this.textBoxSearchParts = new System.Windows.Forms.TextBox();
            this.buttonSearchParts = new System.Windows.Forms.Button();
            this.buttonDataGridViewPartsDelete = new System.Windows.Forms.Button();
            this.buttonDataGridViewPartsModify = new System.Windows.Forms.Button();
            this.buttonDataGridViewPartsAdd = new System.Windows.Forms.Button();
            this.buttonDataGridViewProductsAdd = new System.Windows.Forms.Button();
            this.buttonDataGridViewProductsModify = new System.Windows.Forms.Button();
            this.buttonDataGridViewProductsDelete = new System.Windows.Forms.Button();
            this.buttonSearchProducts = new System.Windows.Forms.Button();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.labelDataGridVewProductsTitle = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainScreenTitle
            // 
            this.labelMainScreenTitle.AutoSize = true;
            this.labelMainScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMainScreenTitle.Location = new System.Drawing.Point(12, 9);
            this.labelMainScreenTitle.Name = "labelMainScreenTitle";
            this.labelMainScreenTitle.Size = new System.Drawing.Size(422, 36);
            this.labelMainScreenTitle.TabIndex = 0;
            this.labelMainScreenTitle.Text = "Inventory Management System";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AllowUserToResizeRows = false;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(18, 159);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.RowHeadersVisible = false;
            this.dataGridViewParts.RowHeadersWidth = 51;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParts.ShowEditingIcon = false;
            this.dataGridViewParts.Size = new System.Drawing.Size(474, 291);
            this.dataGridViewParts.TabIndex = 1;
            // 
            // labelDataGridVewPartsTitle
            // 
            this.labelDataGridVewPartsTitle.AutoSize = true;
            this.labelDataGridVewPartsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelDataGridVewPartsTitle.Location = new System.Drawing.Point(12, 123);
            this.labelDataGridVewPartsTitle.Name = "labelDataGridVewPartsTitle";
            this.labelDataGridVewPartsTitle.Size = new System.Drawing.Size(78, 31);
            this.labelDataGridVewPartsTitle.TabIndex = 2;
            this.labelDataGridVewPartsTitle.Text = "Parts";
            // 
            // textBoxSearchParts
            // 
            this.textBoxSearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxSearchParts.Location = new System.Drawing.Point(372, 129);
            this.textBoxSearchParts.Name = "textBoxSearchParts";
            this.textBoxSearchParts.Size = new System.Drawing.Size(120, 24);
            this.textBoxSearchParts.TabIndex = 3;
            this.textBoxSearchParts.WordWrap = false;
            this.textBoxSearchParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartSearchKeyDown);
            // 
            // buttonSearchParts
            // 
            this.buttonSearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSearchParts.Location = new System.Drawing.Point(274, 124);
            this.buttonSearchParts.Name = "buttonSearchParts";
            this.buttonSearchParts.Size = new System.Drawing.Size(81, 31);
            this.buttonSearchParts.TabIndex = 4;
            this.buttonSearchParts.Text = "Search";
            this.buttonSearchParts.UseVisualStyleBackColor = true;
            this.buttonSearchParts.Click += new System.EventHandler(this.PartSearchClick);
            // 
            // buttonDataGridViewPartsDelete
            // 
            this.buttonDataGridViewPartsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewPartsDelete.Location = new System.Drawing.Point(408, 456);
            this.buttonDataGridViewPartsDelete.Name = "buttonDataGridViewPartsDelete";
            this.buttonDataGridViewPartsDelete.Size = new System.Drawing.Size(85, 33);
            this.buttonDataGridViewPartsDelete.TabIndex = 5;
            this.buttonDataGridViewPartsDelete.Text = "Delete";
            this.buttonDataGridViewPartsDelete.UseVisualStyleBackColor = true;
            this.buttonDataGridViewPartsDelete.Click += new System.EventHandler(this.DeletePartClick);
            // 
            // buttonDataGridViewPartsModify
            // 
            this.buttonDataGridViewPartsModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewPartsModify.Location = new System.Drawing.Point(305, 456);
            this.buttonDataGridViewPartsModify.Name = "buttonDataGridViewPartsModify";
            this.buttonDataGridViewPartsModify.Size = new System.Drawing.Size(81, 33);
            this.buttonDataGridViewPartsModify.TabIndex = 6;
            this.buttonDataGridViewPartsModify.Text = "Modify";
            this.buttonDataGridViewPartsModify.UseVisualStyleBackColor = true;
            this.buttonDataGridViewPartsModify.Click += new System.EventHandler(this.ModifyPartClick);
            // 
            // buttonDataGridViewPartsAdd
            // 
            this.buttonDataGridViewPartsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewPartsAdd.Location = new System.Drawing.Point(200, 456);
            this.buttonDataGridViewPartsAdd.Name = "buttonDataGridViewPartsAdd";
            this.buttonDataGridViewPartsAdd.Size = new System.Drawing.Size(86, 33);
            this.buttonDataGridViewPartsAdd.TabIndex = 7;
            this.buttonDataGridViewPartsAdd.Text = "Add";
            this.buttonDataGridViewPartsAdd.UseVisualStyleBackColor = true;
            this.buttonDataGridViewPartsAdd.Click += new System.EventHandler(this.AddPartClick);
            // 
            // buttonDataGridViewProductsAdd
            // 
            this.buttonDataGridViewProductsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewProductsAdd.Location = new System.Drawing.Point(785, 456);
            this.buttonDataGridViewProductsAdd.Name = "buttonDataGridViewProductsAdd";
            this.buttonDataGridViewProductsAdd.Size = new System.Drawing.Size(84, 33);
            this.buttonDataGridViewProductsAdd.TabIndex = 14;
            this.buttonDataGridViewProductsAdd.Text = "Add";
            this.buttonDataGridViewProductsAdd.UseVisualStyleBackColor = true;
            this.buttonDataGridViewProductsAdd.Click += new System.EventHandler(this.AddProductClick);
            // 
            // buttonDataGridViewProductsModify
            // 
            this.buttonDataGridViewProductsModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewProductsModify.Location = new System.Drawing.Point(888, 456);
            this.buttonDataGridViewProductsModify.Name = "buttonDataGridViewProductsModify";
            this.buttonDataGridViewProductsModify.Size = new System.Drawing.Size(81, 33);
            this.buttonDataGridViewProductsModify.TabIndex = 13;
            this.buttonDataGridViewProductsModify.Text = "Modify";
            this.buttonDataGridViewProductsModify.UseVisualStyleBackColor = true;
            this.buttonDataGridViewProductsModify.Click += new System.EventHandler(this.ModifyProductClick);
            // 
            // buttonDataGridViewProductsDelete
            // 
            this.buttonDataGridViewProductsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDataGridViewProductsDelete.Location = new System.Drawing.Point(996, 456);
            this.buttonDataGridViewProductsDelete.Name = "buttonDataGridViewProductsDelete";
            this.buttonDataGridViewProductsDelete.Size = new System.Drawing.Size(80, 33);
            this.buttonDataGridViewProductsDelete.TabIndex = 12;
            this.buttonDataGridViewProductsDelete.Text = "Delete";
            this.buttonDataGridViewProductsDelete.UseVisualStyleBackColor = true;
            this.buttonDataGridViewProductsDelete.Click += new System.EventHandler(this.DeleteProductClick);
            // 
            // buttonSearchProducts
            // 
            this.buttonSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSearchProducts.Location = new System.Drawing.Point(866, 124);
            this.buttonSearchProducts.Name = "buttonSearchProducts";
            this.buttonSearchProducts.Size = new System.Drawing.Size(81, 31);
            this.buttonSearchProducts.TabIndex = 11;
            this.buttonSearchProducts.Text = "Search";
            this.buttonSearchProducts.UseVisualStyleBackColor = true;
            this.buttonSearchProducts.Click += new System.EventHandler(this.ProductSearchClick);
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxSearchProducts.Location = new System.Drawing.Point(965, 127);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(111, 24);
            this.textBoxSearchProducts.TabIndex = 10;
            this.textBoxSearchProducts.WordWrap = false;
            this.textBoxSearchProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSearchKeyDown);
            // 
            // labelDataGridVewProductsTitle
            // 
            this.labelDataGridVewProductsTitle.AutoSize = true;
            this.labelDataGridVewProductsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelDataGridVewProductsTitle.Location = new System.Drawing.Point(565, 124);
            this.labelDataGridVewProductsTitle.Name = "labelDataGridVewProductsTitle";
            this.labelDataGridVewProductsTitle.Size = new System.Drawing.Size(122, 31);
            this.labelDataGridVewProductsTitle.TabIndex = 9;
            this.labelDataGridVewProductsTitle.Text = "Products";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(576, 159);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.ShowEditingIcon = false;
            this.dataGridViewProducts.Size = new System.Drawing.Size(500, 291);
            this.dataGridViewProducts.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonExit.Location = new System.Drawing.Point(998, 543);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(78, 34);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitMainScreenClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 589);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDataGridViewProductsAdd);
            this.Controls.Add(this.buttonDataGridViewProductsModify);
            this.Controls.Add(this.buttonDataGridViewProductsDelete);
            this.Controls.Add(this.buttonSearchProducts);
            this.Controls.Add(this.textBoxSearchProducts);
            this.Controls.Add(this.labelDataGridVewProductsTitle);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonDataGridViewPartsAdd);
            this.Controls.Add(this.buttonDataGridViewPartsModify);
            this.Controls.Add(this.buttonDataGridViewPartsDelete);
            this.Controls.Add(this.buttonSearchParts);
            this.Controls.Add(this.textBoxSearchParts);
            this.Controls.Add(this.labelDataGridVewPartsTitle);
            this.Controls.Add(this.dataGridViewParts);
            this.Controls.Add(this.labelMainScreenTitle);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainScreenTitle;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Label labelDataGridVewPartsTitle;
        private System.Windows.Forms.TextBox textBoxSearchParts;
        private System.Windows.Forms.Button buttonSearchParts;
        private System.Windows.Forms.Button buttonDataGridViewPartsDelete;
        private System.Windows.Forms.Button buttonDataGridViewPartsModify;
        private System.Windows.Forms.Button buttonDataGridViewPartsAdd;
        private System.Windows.Forms.Button buttonDataGridViewProductsAdd;
        private System.Windows.Forms.Button buttonDataGridViewProductsModify;
        private System.Windows.Forms.Button buttonDataGridViewProductsDelete;
        private System.Windows.Forms.Button buttonSearchProducts;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Label labelDataGridVewProductsTitle;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonExit;
    }
}