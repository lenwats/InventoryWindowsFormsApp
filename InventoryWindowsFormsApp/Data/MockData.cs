using InventoryWindowsFormsApp.Domain;

namespace InventoryWindowsFormsApp.Data
{
    public class MockData
    {
        public static InHouse InHouse = new InHouse(1, "Chain", 8, 13, 5, 25, "2400");

        public static Outsourced Outsourced = new Outsourced(2, "Seat", 10, 5, 5, 25, "The Bike Store");

        public static Product Product1 = new Product(1, "Mountain Bike", 135, 6, 3, 12);

        public static Product Product2 = new Product(2, "Road Bike", 165, 2, 2, 10);
    }
}
