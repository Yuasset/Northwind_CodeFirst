using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographic> builder)
        {
            builder.HasKey(customerdemographic => customerdemographic.ID);
            builder.Property(customerdemographic => customerdemographic.ID).UseIdentityColumn();
            builder.HasMany(customerdemographic => customerdemographic.CustomerCustomerDemographics).WithOne(customercustomerdemographic => customercustomerdemographic.CustomerDemographic).HasForeignKey(customerdemograpich => customerdemograpich.CustomerTypeID);
        }
    }
}
