using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWindowsFormsApp.Domain
{
    public class Product
    {

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        [DisplayName("Product Id")]
        public int ProductID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("In Stock")]
        public int InStock { get; set; }

        [DisplayName("Min")]
        public int Min { get; set; }

        [DisplayName("Max")]
        public int Max { get; set; }

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int id)
        {
            return AssociatedParts.Remove(LookupAssociatedPart(id));
        }

        public Part LookupAssociatedPart(int id)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == id);
        }
    }
}
