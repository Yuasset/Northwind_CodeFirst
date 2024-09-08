using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order => order.ID);
            builder.Property(order => order.ID).UseIdentityColumn();
            builder.HasOne(order => order.Customer).WithMany(customer => customer.Orders).HasForeignKey(order => order.CustomerID);
            builder.HasOne(order => order.Employee).WithMany(employee => employee.Orders).HasForeignKey(order => order.EmployeeID);
            builder.HasMany(order => order.OrderDetails).WithOne(orderdetail => orderdetail.Order).HasForeignKey(order => order.OrderID);

            builder.HasData(OrderData.Data());
        }
    }
}
