using DAL.Entities;

namespace DAL.Data
{
    internal class OrderDetailData
    {
        public static List<OrderDetail> Data()
        {
            return new List<OrderDetail>
            {
                new OrderDetail
                {
                    ID = 1,
                    OrderID = 1,
                    ProductID = 1,
                    Quantity = 1,
                    UnitPrice = 10,
                    Discount = 0,
                },
                new OrderDetail
                {
                    ID = 3,
                    OrderID = 3,
                    ProductID = 1,
                    Quantity = 3,
                    UnitPrice = 10,
                    Discount = 0,
                },
            };
        }
    }
}
