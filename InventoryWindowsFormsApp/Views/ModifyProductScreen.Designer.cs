
namespace InventoryWindowsFormsApp.Views
{
    partial class ModifyProductScreen
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
            this.cancelProductButton = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.assocPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.addCandidateButton = new System.Windows.Forms.Button();
            this.candidatePartsButton = new System.Windows.Forms.Button();
            this.candidatePartsSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.candidatePartsDataGrid = new System.Windows.Forms.DataGridView();
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
            this.modProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelProductButton
            // 
            this.cancelProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelProductButton.Location = new System.Drawing.Point(586, 512);
            this.cancelProductButton.Name = "cancelProductButton";
            this.cancelProductButton.Size = new System.Drawing.Size(82, 31);
            this.cancelProductButton.TabIndex = 61;
            this.cancelProductButton.Text = "Cancel";
            this.cancelProductButton.UseVisualStyleBackColor = true;
            this.cancelProductButton.Click += new System.EventHandler(this.CancelModifiedProductClick);
            // 
            // saveProductButton
            // 
            this.saveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveProductButton.Location = new System.Drawing.Point(470, 512);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(82, 31);
            this.saveProductButton.TabIndex = 60;
            this.saveProductButton.Text = "Save";
            this.saveProductButton.UseVisualStyleBackColor = true;
            this.saveProductButton.Click += new System.EventHandler(this.SaveModifiedProductClick);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deletePartButton.Location = new System.Drawing.Point(1000, 464);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(77, 35);
            this.deletePartButton.TabIndex = 59;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeleteAssociatedPartClick);
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.assocPartsLabel.Location = new System.Drawing.Point(470, 276);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(233, 18);
            this.assocPartsLabel.TabIndex = 58;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // assocPartsDataGrid
            // 
            this.assocPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assocPartsDataGrid.Location = new System.Drawing.Point(470, 299);
            this.assocPartsDataGrid.Name = "assocPartsDataGrid";
            this.assocPartsDataGrid.RowHeadersVisible = false;
            this.assocPartsDataGrid.RowHeadersWidth = 51;
            this.assocPartsDataGrid.RowTemplate.Height = 24;
            this.assocPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assocPartsDataGrid.Size = new System.Drawing.Size(608, 158);
            this.assocPartsDataGrid.TabIndex = 57;
            // 
            // addCandidateButton
            // 
            this.addCandidateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addCandidateButton.Location = new System.Drawing.Point(1000, 228);
            this.addCandidateButton.Name = "addCandidateButton";
            this.addCandidateButton.Size = new System.Drawing.Size(77, 35);
            this.addCandidateButton.TabIndex = 56;
            this.addCandidateButton.Text = "Add";
            this.addCandidateButton.UseVisualStyleBackColor = true;
            this.addCandidateButton.Click += new System.EventHandler(this.AddAssociatedPartClick);
            // 
            // candidatePartsButton
            // 
            this.candidatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.candidatePartsButton.Location = new System.Drawing.Point(852, 25);
            this.candidatePartsButton.Name = "candidatePartsButton";
            this.candidatePartsButton.Size = new System.Drawing.Size(81, 33);
            this.candidatePartsButton.TabIndex = 55;
            this.candidatePartsButton.Text = "Search";
            this.candidatePartsButton.UseVisualStyleBackColor = true;
            this.candidatePartsButton.Click += new System.EventHandler(this.CandidatePartsSearchClick);
            // 
            // candidatePartsSearch
            // 
            this.candidatePartsSearch.Location = new System.Drawing.Point(940, 31);
            this.candidatePartsSearch.Name = "candidatePartsSearch";
            this.candidatePartsSearch.Size = new System.Drawing.Size(138, 22);
            this.candidatePartsSearch.TabIndex = 54;
            this.candidatePartsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CandidatePartsSearchKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(470, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "All Candidate Parts";
            // 
            // candidatePartsDataGrid
            // 
            this.candidatePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsDataGrid.Location = new System.Drawing.Point(470, 63);
            this.candidatePartsDataGrid.Name = "candidatePartsDataGrid";
            this.candidatePartsDataGrid.RowHeadersVisible = false;
            this.candidatePartsDataGrid.RowHeadersWidth = 51;
            this.candidatePartsDataGrid.RowTemplate.Height = 24;
            this.candidatePartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsDataGrid.Size = new System.Drawing.Size(608, 158);
            this.candidatePartsDataGrid.TabIndex = 52;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productMinLabel.Location = new System.Drawing.Point(201, 360);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(32, 18);
            this.productMinLabel.TabIndex = 51;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productMaxLabel.Location = new System.Drawing.Point(54, 361);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.productMaxLabel.TabIndex = 50;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productPriceLabel.Location = new System.Drawing.Point(12, 299);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(78, 18);
            this.productPriceLabel.TabIndex = 49;
            this.productPriceLabel.Text = "Price/Cost";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productInventoryLabel.Location = new System.Drawing.Point(23, 245);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.productInventoryLabel.TabIndex = 48;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productNameLabel.Location = new System.Drawing.Point(42, 191);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(48, 18);
            this.productNameLabel.TabIndex = 47;
            this.productNameLabel.Text = "Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productIDLabel.Location = new System.Drawing.Point(68, 137);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(22, 18);
            this.productIDLabel.TabIndex = 46;
            this.productIDLabel.Text = "ID";
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Location = new System.Drawing.Point(117, 360);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(45, 22);
            this.productMaxTextBox.TabIndex = 45;
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Location = new System.Drawing.Point(261, 361);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(42, 22);
            this.productMinTextBox.TabIndex = 44;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(117, 299);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(186, 22);
            this.productPriceTextBox.TabIndex = 43;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Location = new System.Drawing.Point(117, 245);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(186, 22);
            this.productInventoryTextBox.TabIndex = 42;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(117, 191);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(186, 22);
            this.productNameTextBox.TabIndex = 41;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(117, 137);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(186, 22);
            this.productIDTextBox.TabIndex = 40;
            // 
            // modProductLabel
            // 
            this.modProductLabel.AutoSize = true;
            this.modProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.modProductLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modProductLabel.Location = new System.Drawing.Point(13, 13);
            this.modProductLabel.Name = "modProductLabel";
            this.modProductLabel.Size = new System.Drawing.Size(195, 31);
            this.modProductLabel.TabIndex = 62;
            this.modProductLabel.Text = "Modify Product";
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 568);
            this.Controls.Add(this.modProductLabel);
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
            this.Name = "ModifyProductScreen";
            this.Text = "ModifyProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelProductButton;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.DataGridView assocPartsDataGrid;
        private System.Windows.Forms.Button addCandidateButton;
        private System.Windows.Forms.Button candidatePartsButton;
        private System.Windows.Forms.TextBox candidatePartsSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView candidatePartsDataGrid;
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
        private System.Windows.Forms.Label modProductLabel;
    }
}