using DAL.Entities;

namespace DAL.Data
{
    internal class ProductData
    {
        public static List<Product> Data()
        {
            return new List<Product>{
                new Product
                {
                    ID = 1,
                    ProductName = "Chai",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = 10,
                    UnitPrice = 18,
                    UnitsInStock = 39,
                    UnitsOnOrder = 0,
                    ReOrderLevel = 10,
                    Discontinued = 0
                }
            };
        }
    }
}
