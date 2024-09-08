using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Ignore(orderdetail => orderdetail.ID);
            builder.HasKey(orderdetail => new { orderdetail.OrderID, orderdetail.ProductID });

            builder.HasData(OrderDetailData.Data());
        }
    }
}
