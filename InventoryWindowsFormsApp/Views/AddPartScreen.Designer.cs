
namespace InventoryWindowsFormsApp.Views
{
    partial class AddPartScreen
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
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.partSourceTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partSourceLabel = new System.Windows.Forms.Label();
            this.savePartButton = new System.Windows.Forms.Button();
            this.cancelPartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Enabled = false;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AddPartLabel.Location = new System.Drawing.Point(12, 9);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(119, 31);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InHouseRadio.Location = new System.Drawing.Point(223, 88);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(89, 22);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadioCheckChange);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OutsourcedRadio.Location = new System.Drawing.Point(410, 88);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(107, 22);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadioCheckChange);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(223, 157);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(294, 22);
            this.partIDTextBox.TabIndex = 3;
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(223, 211);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(294, 22);
            this.partNameTextBox.TabIndex = 4;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(223, 265);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(294, 22);
            this.partInventoryTextBox.TabIndex = 5;
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(223, 319);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(294, 22);
            this.partPriceTextBox.TabIndex = 6;
            // 
            // partSourceTextBox
            // 
            this.partSourceTextBox.Location = new System.Drawing.Point(223, 438);
            this.partSourceTextBox.Name = "partSourceTextBox";
            this.partSourceTextBox.Size = new System.Drawing.Size(294, 22);
            this.partSourceTextBox.TabIndex = 7;
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(433, 381);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(84, 22);
            this.partMinTextBox.TabIndex = 8;
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(223, 381);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(89, 22);
            this.partMaxTextBox.TabIndex = 9;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partIDLabel.Location = new System.Drawing.Point(144, 157);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(22, 18);
            this.partIDLabel.TabIndex = 10;
            this.partIDLabel.Text = "ID";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partNameLabel.Location = new System.Drawing.Point(118, 211);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(48, 18);
            this.partNameLabel.TabIndex = 11;
            this.partNameLabel.Text = "Name";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partInventoryLabel.Location = new System.Drawing.Point(99, 265);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.partInventoryLabel.TabIndex = 12;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partPriceLabel.Location = new System.Drawing.Point(88, 319);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(78, 18);
            this.partPriceLabel.TabIndex = 13;
            this.partPriceLabel.Text = "Price/Cost";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partMaxLabel.Location = new System.Drawing.Point(130, 381);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.partMaxLabel.TabIndex = 14;
            this.partMaxLabel.Text = "Max";
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partMinLabel.Location = new System.Drawing.Point(377, 382);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(32, 18);
            this.partMinLabel.TabIndex = 15;
            this.partMinLabel.Text = "Min";
            // 
            // partSourceLabel
            // 
            this.partSourceLabel.AutoSize = true;
            this.partSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partSourceLabel.Location = new System.Drawing.Point(84, 438);
            this.partSourceLabel.Name = "partSourceLabel";
            this.partSourceLabel.Size = new System.Drawing.Size(82, 18);
            this.partSourceLabel.TabIndex = 16;
            this.partSourceLabel.Text = "Machine ID";
            // 
            // savePartButton
            // 
            this.savePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.savePartButton.Location = new System.Drawing.Point(236, 523);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(76, 34);
            this.savePartButton.TabIndex = 17;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = false;
            this.savePartButton.Click += new System.EventHandler(this.SavePartClick);
            // 
            // cancelPartButton
            // 
            this.cancelPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelPartButton.Location = new System.Drawing.Point(410, 523);
            this.cancelPartButton.Name = "cancelPartButton";
            this.cancelPartButton.Size = new System.Drawing.Size(76, 34);
            this.cancelPartButton.TabIndex = 18;
            this.cancelPartButton.Text = "Cancel";
            this.cancelPartButton.UseVisualStyleBackColor = false;
            this.cancelPartButton.Click += new System.EventHandler(this.CancelAddPartClick);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 586);
            this.Controls.Add(this.cancelPartButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.partSourceLabel);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partSourceTextBox);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPartScreen";
            this.Text = "AddPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.TextBox partSourceTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Label partSourceLabel;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelPartButton;
    }
}