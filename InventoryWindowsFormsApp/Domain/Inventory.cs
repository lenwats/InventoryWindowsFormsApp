using System.ComponentModel;
using System.Linq;
using InventoryWindowsFormsApp.Data;

namespace InventoryWindowsFormsApp.Domain
{
    public class Inventory
    {
        /// <summary>
        /// In order to get data binding in WinForms (to a DataGridView, for instance) 
        /// to work you have to use a BindingList (or DataTable) instead of a generic List. 
        /// </summary>
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        /// <summary>
        /// Seed Data
        /// </summary>
        public static void InitializeTables()
        {
            AllParts.Add(MockData.InHouse);
            AllParts.Add(MockData.Outsourced);
            Products.Add(MockData.Product1);
            Products.Add(MockData.Product2);
        }


        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int id)
        {
            var product = LookupProduct(id);
            return Products.Remove(product);
        }

        public static Product LookupProduct(int id)
        {
            return Products.FirstOrDefault(p => p.ProductID == id);
        }

        public static void UpdateProduct(int id, Product updatedProduct)
        {
            var product = LookupProduct(id);

            if (product != null)
            {
                product.AssociatedParts = updatedProduct.AssociatedParts;
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.InStock = updatedProduct.InStock;
                product.Min = updatedProduct.Min;
                product.Max = updatedProduct.Max;
            }

        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part LookupPart(int id)
        {
            return AllParts.FirstOrDefault(p => p.PartID == id);
        }

        public static void UpdatePart(int id, Part updatedPart)
        {
            var part = LookupPart(id);

            if (part != null)
            {
                AllParts.Remove(part);
                AllParts.Add(updatedPart);
            }
        }
    }
}
