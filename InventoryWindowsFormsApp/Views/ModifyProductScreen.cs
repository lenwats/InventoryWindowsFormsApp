using InventoryWindowsFormsApp.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryWindowsFormsApp.Views
{
    public partial class ModifyProductScreen : Form
    {
        /// <summary>
        /// This is the part selected to modify
        /// </summary>
        private Product CurrentProduct;

        public ModifyProductScreen(Product prodToMod)
        {
            InitializeComponent();

            candidatePartsDataGrid.DataSource = Inventory.AllParts;

            productIDTextBox.Text = prodToMod.ProductID.ToString();
            productNameTextBox.Text = prodToMod.Name;
            productPriceTextBox.Text = prodToMod.Price.ToString();
            productInventoryTextBox.Text = prodToMod.InStock.ToString();
            productMaxTextBox.Text = prodToMod.Max.ToString();
            productMinTextBox.Text = prodToMod.Min.ToString();

            CurrentProduct = prodToMod;

            assocPartsDataGrid.DataSource = CurrentProduct.AssociatedParts;            
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

        private void CandidatePartsSearchClick(object sender, EventArgs e)
        {
            SearchForCandidatePart(candidatePartsSearch.Text);
        }

        private void CandidatePartsSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchForCandidatePart(candidatePartsSearch.Text);
            }
        }

        /// <summary>
        /// Associate a new part with the selected product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAssociatedPartClick(object sender, EventArgs e)
        {
            Part partToAdd = (Part)candidatePartsDataGrid.CurrentRow.DataBoundItem;

            if (partToAdd != null)
            {
                if (CurrentProduct.LookupAssociatedPart(partToAdd.PartID) != null)
                {
                    MessageBox.Show("This part is already associated with the product.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CurrentProduct.AddAssociatedPart(partToAdd);
                }
            }
        }

        /// <summary>
        /// Disassociate a part from the selected product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAssociatedPartClick(object sender, EventArgs e)
        {
            DialogResult selection = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selection == DialogResult.Yes)
            {
                assocPartsDataGrid.Rows.Remove(assocPartsDataGrid.CurrentRow);
            }
        }

        private void SaveModifiedProductClick(object sender, EventArgs e)
        {
            try
            {
                CurrentProduct.Name = productNameTextBox.Text;
                CurrentProduct.InStock = int.Parse(productInventoryTextBox.Text);
                CurrentProduct.Price = decimal.Parse(productPriceTextBox.Text);
                CurrentProduct.Min = int.Parse(productMinTextBox.Text);
                CurrentProduct.Max = int.Parse(productMaxTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Do not enter invalid values (i.e., letters, symbols other than '.')", "INVALID ENTRY");
                return;
            }

            if (CurrentProduct.Min > CurrentProduct.Max)
            {
                MessageBox.Show("The minimum value must be lower than the maximum value.", "INVALID MIN OR MAX STOCK");
                return;
            }
            else if (CurrentProduct.Min > CurrentProduct.InStock || CurrentProduct.Max < CurrentProduct.InStock)
            {
                MessageBox.Show("The current number of items in inventory must be between the minimum and maximum values.", "INVALID MIN, MAX OR CURRENT STOCK");
                return;
            }

            Product modifiedProduct = new Product(CurrentProduct.ProductID, CurrentProduct.Name, CurrentProduct.Price, CurrentProduct.InStock, CurrentProduct.Min, CurrentProduct.Max);
            
            modifiedProduct.AssociatedParts = CurrentProduct.AssociatedParts;
            assocPartsDataGrid.DataSource = modifiedProduct.AssociatedParts;

            Inventory.UpdateProduct(CurrentProduct.ProductID, modifiedProduct);
            Close();
        }

        private void CancelModifiedProductClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
