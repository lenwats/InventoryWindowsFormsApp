using InventoryWindowsFormsApp.Domain;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryWindowsFormsApp.Views
{
    public partial class AddProductScreen : Form
    {
        BindingList<Part> Parts = new BindingList<Part>();

        private int productCount = Inventory.Products.Count + 1;

        public AddProductScreen()
        {
            InitializeComponent();
            assocPartsDataGrid.DataSource = Parts;
            candidatePartsDataGrid.DataSource = Inventory.AllParts;
        }

        private void SearchForCandidatePart(string searchText)
        {
            var part = Inventory.AllParts.FirstOrDefault(p => p.Name.ToUpper().Contains(searchText.ToUpper()));
            if (part != null)
            {
                var index = Inventory.AllParts.IndexOf(part);
                candidatePartsDataGrid.CurrentCell = candidatePartsDataGrid.Rows[index].Cells[1];
            }
        }

        private void CandidateSearchClick(object sender, EventArgs e)
        {
            SearchForCandidatePart(candidatePartsSearch.Text);
        }

        private void CandidateSearchKeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                SearchForCandidatePart(candidatePartsSearch.Text);
            }
        }

        /// <summary>
        /// Associate a new part with the new product
        /// </summary>
        private void AddCandidatePartClick(object sender, EventArgs e)
        {
            Parts.Add((Part)candidatePartsDataGrid.CurrentRow.DataBoundItem);
        }

        /// <summary>
        /// Disassociate a part from the new product
        /// </summary>
        private void DeleteAssociatedPartClick(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Do you want to disassociate this part?", "Remove Associated Part", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (response == DialogResult.OK)
            {
                Parts.Remove((Part)assocPartsDataGrid.CurrentRow.DataBoundItem);
            }
        }

        private void SaveNewProductClick(object sender, EventArgs e)
        {
            int productID = productCount;
            string productName = productNameTextBox.Text;
            int inventory, min, max;
            decimal price;

            try
            {
                inventory = Convert.ToInt32(productInventoryTextBox.Text);
                price = Convert.ToDecimal(productPriceTextBox.Text);
                min = Convert.ToInt32(productMinTextBox.Text);
                max = Convert.ToInt32(productMaxTextBox.Text);
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

            Product newProduct = new Product(productID, productName, price, inventory, min, max);
            newProduct.AssociatedParts = Parts;
            Inventory.AddProduct(newProduct);
            this.Hide();
        }

        private void CancelNewProductClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
