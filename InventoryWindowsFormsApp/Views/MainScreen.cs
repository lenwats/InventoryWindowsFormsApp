using System;
using System.Linq;
using System.Windows.Forms;
using InventoryWindowsFormsApp.Views;
using InventoryWindowsFormsApp.Domain;

namespace InventoryWindowsFormsApp.Views
{
    public partial class MainScreen : Form
    {
        
        public Inventory Inventory { get; set; }

        public MainScreen()
        {
            InitializeComponent();

            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewProducts.DataSource = Inventory.Products;

            Inventory.InitializeTables();
        }


        private void SearchForPart(string searchText)
        {
            var part = Inventory.AllParts.FirstOrDefault(p => p.Name.ToUpper().Contains(searchText.ToUpper()));
            if (part != null)
            {
                var index = Inventory.AllParts.IndexOf(part);
                dataGridViewParts.CurrentCell = dataGridViewParts.Rows[index].Cells[1];
            }
        }

        private void PartSearchClick(object sender, EventArgs e)
        {
            SearchForPart(textBoxSearchParts.Text);
        }

        private void PartSearchKeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                SearchForPart(textBoxSearchParts.Text);
            }
        }

        private void AddPartClick(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen = new AddPartScreen();
            addPartScreen.Show();
        }

        private void ModifyPartClick(object sender, EventArgs e)
        {
            if (dataGridViewParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHousePart = (InHouse)dataGridViewParts.CurrentRow.DataBoundItem;
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen(inHousePart);
                modifyPartScreen.Show();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)dataGridViewParts.CurrentRow.DataBoundItem;
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen(outsourcedPart);
                modifyPartScreen.Show();
            }
        }

        private void DeletePartClick(object sender, EventArgs e)
        {
            DialogResult selection = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selection == DialogResult.Yes)
            {
                dataGridViewParts.Rows.Remove(dataGridViewParts.CurrentRow);
            }
        }

        private void SearchForProduct(string searchText)
        {
            var product = Inventory.Products.FirstOrDefault(p => p.Name.ToUpper().Contains(searchText.ToUpper()));
            if (product != null)
            {
                var index = Inventory.Products.IndexOf(product);
                dataGridViewProducts.CurrentCell = dataGridViewProducts.Rows[index].Cells[1];
            }
        }

        private void ProductSearchClick(object sender, EventArgs e)
        {
            SearchForProduct(textBoxSearchProducts.Text);
        }

        private void ProductSearchKeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                SearchForProduct(textBoxSearchProducts.Text);
            }
        }

        private void AddProductClick(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.Show();
        }

        private void ModifyProductClick(object sender, EventArgs e)
        {
            ModifyProductScreen modifyProductScreen = new ModifyProductScreen((Product)dataGridViewProducts.CurrentRow.DataBoundItem);
            modifyProductScreen.Show();
        }

        private void DeleteProductClick(object sender, EventArgs e)
        {
            // if the selected product has associated parts do not delete it (show dialog)
            Product prodToDelete = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;

            if (prodToDelete.AssociatedParts.Count > 0)
            {
                MessageBox.Show("You cannot delete this product while it has associated parts. Please unassociate any parts before deleting.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.OK)
                {
                    Inventory.RemoveProduct(prodToDelete.ProductID);
                }
            }

        }

        private void ExitMainScreenClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
