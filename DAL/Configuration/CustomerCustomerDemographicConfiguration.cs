using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class CustomerCustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerCustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemographic> builder)
        {
            builder.Ignore(customercustomerdemographicconfiguration => customercustomerdemographicconfiguration.ID);
            builder.HasKey(customercustomerdemographicconfiguration => new { customercustomerdemographicconfiguration.CustomerID, customercustomerdemographicconfiguration.CustomerTypeID });
        }
    }
}
