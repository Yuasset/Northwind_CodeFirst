using DAL.Abstracts;

namespace DAL.Entities
{
    public class Product : Base
    {
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public int Discontinued { get; set; }
        //Mapping
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
