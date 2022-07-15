
namespace InventoryWindowsFormsApp.Views
{
    partial class AddProductScreen
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.candidatePartsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.candidatePartsSearch = new System.Windows.Forms.TextBox();
            this.candidatePartsButton = new System.Windows.Forms.Button();
            this.addCandidateButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.assocPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.cancelProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addProductLabel.Location = new System.Drawing.Point(13, 13);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(163, 31);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productMinLabel.Location = new System.Drawing.Point(215, 386);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(32, 18);
            this.productMinLabel.TabIndex = 27;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productMaxLabel.Location = new System.Drawing.Point(68, 387);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.productMaxLabel.TabIndex = 26;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productPriceLabel.Location = new System.Drawing.Point(26, 325);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(78, 18);
            this.productPriceLabel.TabIndex = 25;
            this.productPriceLabel.Text = "Price/Cost";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productInventoryLabel.Location = new System.Drawing.Point(37, 271);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.productInventoryLabel.TabIndex = 24;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productNameLabel.Location = new System.Drawing.Point(56, 217);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(48, 18);
            this.productNameLabel.TabIndex = 23;
            this.productNameLabel.Text = "Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productIDLabel.Location = new System.Drawing.Point(82, 163);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(22, 18);
            this.productIDLabel.TabIndex = 22;
            this.productIDLabel.Text = "ID";
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Location = new System.Drawing.Point(131, 386);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(45, 22);
            this.productMaxTextBox.TabIndex = 21;
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Location = new System.Drawing.Point(275, 387);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(42, 22);
            this.productMinTextBox.TabIndex = 20;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(131, 325);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(186, 22);
            this.productPriceTextBox.TabIndex = 19;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Location = new System.Drawing.Point(131, 271);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(186, 22);
            this.productInventoryTextBox.TabIndex = 18;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(131, 217);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(186, 22);
            this.productNameTextBox.TabIndex = 17;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(131, 163);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(186, 22);
            this.productIDTextBox.TabIndex = 16;
            // 
            // candidatePartsDataGrid
            // 
            this.candidatePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsDataGrid.Location = new System.Drawing.Point(484, 89);
            this.candidatePartsDataGrid.Name = "candidatePartsDataGrid";
            this.candidatePartsDataGrid.RowHeadersVisible = false;
            this.candidatePartsDataGrid.RowHeadersWidth = 51;
            this.candidatePartsDataGrid.RowTemplate.Height = 24;
            this.candidatePartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsDataGrid.Size = new System.Drawing.Size(608, 158);
            this.candidatePartsDataGrid.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(484, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "All Candidate Parts";
            // 
            // candidatePartsSearch
            // 
            this.candidatePartsSearch.Location = new System.Drawing.Point(954, 57);
            this.candidatePartsSearch.Name = "candidatePartsSearch";
            this.candidatePartsSearch.Size = new System.Drawing.Size(138, 22);
            this.candidatePartsSearch.TabIndex = 30;
            this.candidatePartsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CandidateSearchKeyDown);
            // 
            // candidatePartsButton
            // 
            this.candidatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.candidatePartsButton.Location = new System.Drawing.Point(866, 51);
            this.candidatePartsButton.Name = "candidatePartsButton";
            this.candidatePartsButton.Size = new System.Drawing.Size(81, 33);
            this.candidatePartsButton.TabIndex = 31;
            this.candidatePartsButton.Text = "Search";
            this.candidatePartsButton.UseVisualStyleBackColor = true;
            this.candidatePartsButton.Click += new System.EventHandler(this.CandidateSearchClick);
            // 
            // addCandidateButton
            // 
            this.addCandidateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addCandidateButton.Location = new System.Drawing.Point(1014, 254);
            this.addCandidateButton.Name = "addCandidateButton";
            this.addCandidateButton.Size = new System.Drawing.Size(77, 35);
            this.addCandidateButton.TabIndex = 32;
            this.addCandidateButton.Text = "Add";
            this.addCandidateButton.UseVisualStyleBackColor = true;
            this.addCandidateButton.Click += new System.EventHandler(this.AddCandidatePartClick);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deletePartButton.Location = new System.Drawing.Point(1014, 490);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(77, 35);
            this.deletePartButton.TabIndex = 37;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeleteAssociatedPartClick);
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.assocPartsLabel.Location = new System.Drawing.Point(484, 302);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(233, 18);
            this.assocPartsLabel.TabIndex = 34;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // assocPartsDataGrid
            // 
            this.assocPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assocPartsDataGrid.Location = new System.Drawing.Point(484, 325);
            this.assocPartsDataGrid.Name = "assocPartsDataGrid";
            this.assocPartsDataGrid.RowHeadersVisible = false;
            this.assocPartsDataGrid.RowHeadersWidth = 51;
            this.assocPartsDataGrid.RowTemplate.Height = 24;
            this.assocPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assocPartsDataGrid.Size = new System.Drawing.Size(608, 158);
            this.assocPartsDataGrid.TabIndex = 33;
            // 
            // saveProductButton
            // 
            this.saveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveProductButton.Location = new System.Drawing.Point(484, 538);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(82, 31);
            this.saveProductButton.TabIndex = 38;
            this.saveProductButton.Text = "Save";
            this.saveProductButton.UseVisualStyleBackColor = true;
            this.saveProductButton.Click += new System.EventHandler(this.SaveNewProductClick);
            // 
            // cancelProductButton
            // 
            this.cancelProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelProductButton.Location = new System.Drawing.Point(600, 538);
            this.cancelProductButton.Name = "cancelProductButton";
            this.cancelProductButton.Size = new System.Drawing.Size(82, 31);
            this.cancelProductButton.TabIndex = 39;
            this.cancelProductButton.Text = "Cancel";
            this.cancelProductButton.UseVisualStyleBackColor = true;
            this.cancelProductButton.Click += new System.EventHandler(this.CancelNewProductClick);
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 581);
            this.Controls.Add(this.cancelProductButton);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.assocPartsLabel);
            this.Controls.Add(this.assocPartsDataGrid);
            this.Controls.Add(this.addCandidateButton);
            this.Controls.Add(this.candidatePartsButton);
            this.Controls.Add(this.candidatePartsSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candidatePartsDataGrid);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productInventoryTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProductScreen";
            this.Text = "AddProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.DataGridView candidatePartsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox candidatePartsSearch;
        private System.Windows.Forms.Button candidatePartsButton;
        private System.Windows.Forms.Button addCandidateButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.DataGridView assocPartsDataGrid;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Button cancelProductButton;
    }
}