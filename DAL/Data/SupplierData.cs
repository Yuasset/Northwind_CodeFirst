using DAL.Entities;

namespace DAL.Data
{
    internal class SupplierData
    {
        public static List<Supplier> Data()
        {
            return new List<Supplier>
            {
                new Supplier
                {
                    ID = 1,
                    CompanyName = "Exotic Liquids",
                    ContactName = "Charlotte Cooper",
                    ContactTitle = "Purchasing Manager",
                    Address = "49 Gilbert St.",
                    City = "London",
                    Region = "",
                    PostalCode = "EC1 4SD",
                    Country = "UK",
                    Phone = "(171) 555-2222",
                    Fax = "",
                    HomePage = ""
                    },
                new Supplier
                {
                    ID = 2,
                    CompanyName = "New Orleans Cajun Delights",
                    ContactName = "Shelley Burke",
                    ContactTitle = "Order Administrator",
                    Address = "P.O. Box 78934",
                    City = "New Orleans",
                    Region = "LA",
                    PostalCode = "70117",
                    Country = "USA",
                    Phone = "(100) 555-4822",
                    Fax = "",
                    HomePage = "#CAJUN.HTM#"
                }
            };
        }
    }
}
