using InventoryWindowsFormsApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowsFormsApp.Views
{
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen(Outsourced partToModify)
        {
            InitializeComponent();
            OutsourcedRadio.Checked = true;
            partIDTextBox.Text = partToModify.PartID.ToString();
            partNameTextBox.Text = partToModify.Name;
            partInventoryTextBox.Text = partToModify.InStock.ToString();
            partPriceTextBox.Text = partToModify.Price.ToString();
            partMinTextBox.Text = partToModify.Min.ToString();
            partMaxTextBox.Text = partToModify.Max.ToString();
            partSourceTextBox.Text = partToModify.Source;
            partSourceLabel.Text = "Company Name";
        }

        public ModifyPartScreen(InHouse partToModify)
        {
            InitializeComponent();
            InHouseRadio.Checked = true;
            partIDTextBox.Text = partToModify.PartID.ToString();
            partNameTextBox.Text = partToModify.Name;
            partInventoryTextBox.Text = partToModify.InStock.ToString();
            partPriceTextBox.Text = partToModify.Price.ToString();
            partMinTextBox.Text = partToModify.Min.ToString();
            partMaxTextBox.Text = partToModify.Max.ToString();
            partSourceTextBox.Text = partToModify.Source.ToString();
        }

        private void InHouseRadioCheckChange(object sender, EventArgs e)
        {
            partSourceLabel.Text = "Machine ID";
        }

        private void OutsourcedRadioCheckChange(object sender, EventArgs e)
        {
            partSourceLabel.Text = "Company Name";
        }

        private void SavePartClick(object sender, EventArgs e)
        {
            int partId = Convert.ToInt32(partIDTextBox.Text);
            int inventory, max, min;
            decimal price;
            string name = partNameTextBox.Text;

            try
            {
                inventory = Convert.ToInt32(partInventoryTextBox.Text);
                price = Convert.ToDecimal(partPriceTextBox.Text);
                max = Convert.ToInt32(partMaxTextBox.Text);
                min = Convert.ToInt32(partMinTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Do not enter invalid values (i.e., letters, symbols other than '.')", "INVALID ENTRY");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("The minimum value must be lower than the maximum value.", "INVALID MIN OR MAX STOCK");
                return;
            }
            else if (min > inventory || max < inventory)
            {
                MessageBox.Show("The current number of items in inventory must be between the minimum and maximum values.", "INVALID MIN, MAX OR CURRENT STOCK");
                return;
            }

            if (InHouseRadio.Checked)
            {
                int machineID;
                try
                {
                    machineID = Convert.ToInt32(partSourceTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Machine IDs must only contain numeric values", "INVALID MACHINE ID");
                    return;
                }

                machineID = Convert.ToInt32(partSourceTextBox.Text);
                InHouse modifiedInHousePart = new InHouse(partId, name, price, inventory, min, max, machineID.ToString());
                Inventory.UpdatePart(partId, modifiedInHousePart);
            }
            else if (OutsourcedRadio.Checked)
            {
                Outsourced modifiedOutsourcedPart = new Outsourced(partId, name, price, inventory, min, max, partSourceTextBox.Text);
                Inventory.UpdatePart(partId, modifiedOutsourcedPart);
            }

            this.Hide();
        }

        private void CancelModifyPartClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
