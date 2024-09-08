using DAL.Abstracts;

namespace DAL.Entities
{
    public class OrderDetail : Base
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        //Mapping
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
