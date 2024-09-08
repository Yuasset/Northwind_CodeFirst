using DAL.Entities;

namespace DAL.Data
{
    internal class OrderData
    {
        public static List<Order> Data()
        {
            return new List<Order>
            {
                new Order
                {
                    ID = 1,
                    CustomerID = 1,
                    EmployeeID = 5,
                    OrderDate = new DateTime(1996, 7, 4),
                    RequiredDate = new DateTime(1996, 8, 1),
                    ShippedDate = new DateTime(1996, 7, 16),
                    ShipVia = 3,
                    Freight = 32.38M,
                    ShipName = "Vins et alcools Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    ShipCity = "Reims",
                    ShipRegion = "",
                    ShipPostalCode = "51100",
                    ShipCountry = "France"
                },
                new Order
                {
                    ID = 3,
                    CustomerID = 2,
                    EmployeeID = 4,
                    OrderDate = new DateTime(1996, 7, 8),
                    RequiredDate = new DateTime(1996, 8, 5),
                    ShippedDate = new DateTime(1996, 7, 12),
                    ShipVia = 2,
                    Freight = 65.83M,
                    ShipName = "Hanari Carnes",
                    ShipAddress = "Rua do Paço, 67",
                    ShipCity = "Rio de Janeiro",
                    ShipRegion = "RJ",
                    ShipPostalCode = "05454-876",
                    ShipCountry = "Brazil"
                },
            };
        }
    }
}
