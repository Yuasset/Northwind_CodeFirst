using DAL.Entities;

namespace DAL.Data
{
    internal class ShipperData
    {
        public static List<Shipper> Data()
        {
            return new List<Shipper>
            {
                new Shipper
                {
                    ID = 1,
                    CompanyName = "Speedy Express",
                    Phone = "(503) 555-9831"
                },
                new Shipper
                {
                    ID = 2,
                    CompanyName = "United Package",
                    Phone = "(503) 555-3199"
                },
                new Shipper
                {
                    ID = 3,
                    CompanyName = "Federal Shipping",
                    Phone = "(503) 555-9931"
                }
            };
        }
    }
}
