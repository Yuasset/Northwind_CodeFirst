using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(supplier => supplier.ID);
            builder.Property(supplier => supplier.ID).UseIdentityColumn();
            builder.HasMany(supplier => supplier.Products).WithOne(product => product.Supplier).HasForeignKey(supplier => supplier.SupplierID);

            builder.HasData(SupplierData.Data());
        }
    }
}
