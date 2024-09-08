using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.ID);
            builder.Property(product => product.ID).UseIdentityColumn();
            builder.HasOne(product => product.Category).WithMany(category => category.Products).HasForeignKey(product => product.CategoryID);
            builder.HasOne(product => product.Supplier).WithMany(supplier => supplier.Products).HasForeignKey(product => product.SupplierID);
            builder.HasMany(product => product.OrderDetails).WithOne(orderdetail => orderdetail.Product).HasForeignKey(product => product.ProductID);

            builder.HasData(ProductData.Data());
        }
    }
}
