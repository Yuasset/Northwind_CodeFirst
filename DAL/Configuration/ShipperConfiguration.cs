using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(shipper => shipper.ID);
            builder.Property(shipper => shipper.ID).UseIdentityColumn();
            builder.HasMany(shipper => shipper.Orders).WithOne(order => order.Shipper).HasForeignKey(shipper => shipper.ShipVia);

            builder.HasData(ShipperData.Data());
        }
    }
}
