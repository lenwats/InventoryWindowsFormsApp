using System.ComponentModel;


namespace InventoryWindowsFormsApp.Domain
{
    public class InHouse : Part
    {
        [DisplayName("Machine Id")]
        public int MachineID { get; set; }

        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, string source) : base(partID, name, price, inStock, min, max, source)
        {
        }

    }
}
