using System.ComponentModel;


namespace InventoryWindowsFormsApp.Domain
{
    public class Outsourced : Part
    {
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string source) : base(partID, name, price, inStock, min, max, source)
        {
        }

    }
}
