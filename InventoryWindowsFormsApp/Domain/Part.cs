using System.ComponentModel;


namespace InventoryWindowsFormsApp.Domain
{
    public class Part
    {
        
        [DisplayName("Part Id")]
        public int PartID { get; set; }

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

        [DisplayName("Source")]
        public string Source { get; set; }

        public Part(int id, string name, decimal price, int inStock, int min, int max, string source)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            Source = source;
        }
    }
}
