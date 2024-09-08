using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(category => category.ID);
            builder.Property(category => category.ID).UseIdentityColumn();
            builder.HasMany(category => category.Products).WithOne(product => product.Category).HasForeignKey(category => category.CategoryID);

            builder.HasData(CategoryData.Data());
        }
    }
}
