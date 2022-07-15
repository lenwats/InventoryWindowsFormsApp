
namespace InventoryWindowsFormsApp.Views
{
    partial class ModifyPartScreen
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
            this.cancelPartButton = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.partSourceLabel = new System.Windows.Forms.Label();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partSourceTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelPartButton
            // 
            this.cancelPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelPartButton.Location = new System.Drawing.Point(315, 390);
            this.cancelPartButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelPartButton.Name = "cancelPartButton";
            this.cancelPartButton.Size = new System.Drawing.Size(57, 28);
            this.cancelPartButton.TabIndex = 36;
            this.cancelPartButton.Text = "Cancel";
            this.cancelPartButton.UseVisualStyleBackColor = false;
            this.cancelPartButton.Click += new System.EventHandler(this.CancelModifyPartClick);
            // 
            // savePartButton
            // 
            this.savePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.savePartButton.Location = new System.Drawing.Point(184, 390);
            this.savePartButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(57, 28);
            this.savePartButton.TabIndex = 35;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = false;
            this.savePartButton.Click += new System.EventHandler(this.SavePartClick);
            // 
            // partSourceLabel
            // 
            this.partSourceLabel.AutoSize = true;
            this.partSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partSourceLabel.Location = new System.Drawing.Point(70, 321);
            this.partSourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partSourceLabel.Name = "partSourceLabel";
            this.partSourceLabel.Size = new System.Drawing.Size(70, 15);
            this.partSourceLabel.TabIndex = 34;
            this.partSourceLabel.Text = "Machine ID";
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partMinLabel.Location = new System.Drawing.Point(290, 275);
            this.partMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(28, 15);
            this.partMinLabel.TabIndex = 33;
            this.partMinLabel.Text = "Min";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partMaxLabel.Location = new System.Drawing.Point(105, 275);
            this.partMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(31, 15);
            this.partMaxLabel.TabIndex = 32;
            this.partMaxLabel.Text = "Max";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partPriceLabel.Location = new System.Drawing.Point(73, 224);
            this.partPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(62, 15);
            this.partPriceLabel.TabIndex = 31;
            this.partPriceLabel.Text = "Price/Cost";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partInventoryLabel.Location = new System.Drawing.Point(81, 180);
            this.partInventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(55, 15);
            this.partInventoryLabel.TabIndex = 30;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partNameLabel.Location = new System.Drawing.Point(95, 136);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(41, 15);
            this.partNameLabel.TabIndex = 29;
            this.partNameLabel.Text = "Name";
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.partIDLabel.Location = new System.Drawing.Point(115, 93);
            this.partIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(19, 15);
            this.partIDLabel.TabIndex = 28;
            this.partIDLabel.Text = "ID";
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(174, 275);
            this.partMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(68, 20);
            this.partMaxTextBox.TabIndex = 27;
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(332, 275);
            this.partMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(64, 20);
            this.partMinTextBox.TabIndex = 26;
            // 
            // partSourceTextBox
            // 
            this.partSourceTextBox.Location = new System.Drawing.Point(174, 321);
            this.partSourceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partSourceTextBox.Name = "partSourceTextBox";
            this.partSourceTextBox.Size = new System.Drawing.Size(222, 20);
            this.partSourceTextBox.TabIndex = 25;
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(174, 224);
            this.partPriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(222, 20);
            this.partPriceTextBox.TabIndex = 24;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(174, 180);
            this.partInventoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(222, 20);
            this.partInventoryTextBox.TabIndex = 23;
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(174, 136);
            this.partNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(222, 20);
            this.partNameTextBox.TabIndex = 22;
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(174, 93);
            this.partIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(222, 20);
            this.partIDTextBox.TabIndex = 21;
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OutsourcedRadio.Location = new System.Drawing.Point(315, 37);
            this.OutsourcedRadio.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(88, 19);
            this.OutsourcedRadio.TabIndex = 20;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadioCheckChange);
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InHouseRadio.Location = new System.Drawing.Point(174, 37);
            this.InHouseRadio.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(75, 19);
            this.InHouseRadio.TabIndex = 19;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadioCheckChange);
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Enabled = false;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ModifyPartLabel.Location = new System.Drawing.Point(11, 9);
            this.ModifyPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(122, 26);
            this.ModifyPartLabel.TabIndex = 37;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.ModifyPartLabel);
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
            this.Name = "ModifyPartScreen";
            this.Text = "ModifyPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelPartButton;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Label partSourceLabel;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partSourceTextBox;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.Label ModifyPartLabel;
    }
}