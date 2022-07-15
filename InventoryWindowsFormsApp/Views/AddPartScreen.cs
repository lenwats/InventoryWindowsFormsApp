using System;
using System.Windows.Forms;
using InventoryWindowsFormsApp.Domain;

namespace InventoryWindowsFormsApp.Views
{
    public partial class AddPartScreen : Form
    {
        private int inventoryCnt = Inventory.AllParts.Count + 1;

        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void InHouseRadioCheckChange(object sender, EventArgs e)
        {
            partSourceLabel.Text = "Machine ID";
            partIDTextBox.Text = inventoryCnt.ToString();
        }

        private void OutsourcedRadioCheckChange(object sender, EventArgs e)
        {
            partSourceLabel.Text = "Company Name";
            partIDTextBox.Text = inventoryCnt.ToString();
        }

        private void SavePartClick(object sender, EventArgs e)
        {
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
                InHouse newInHousePart = new InHouse(inventoryCnt, name, price, inventory, min, max, machineID.ToString());
                Inventory.AddPart(newInHousePart);
            }
            else if (OutsourcedRadio.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(inventoryCnt, name, price, inventory, min, max, partSourceTextBox.Text);
                Inventory.AddPart(newOutsourcedPart);
            }

            this.Hide();
        }

        private void CancelAddPartClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
