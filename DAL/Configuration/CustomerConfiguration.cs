using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).UseIdentityColumn();
            builder.HasMany(customer => customer.CustomerCustomerDemographics).WithOne(customercustomerdemographic => customercustomerdemographic.Customer).HasForeignKey(customer => customer.CustomerID);
            builder.HasMany(customer => customer.Orders).WithOne(order => order.Customer).HasForeignKey(customer => customer.CustomerID);

            builder.HasData(CustomerData.Data());
        }
    }
}
