using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class TerritoryConfiguration : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(territory => territory.ID);
            builder.Property(territory => territory.ID).UseIdentityColumn();
            builder.HasOne(territory => territory.Region).WithMany(region => region.Territories).HasForeignKey(territory => territory.RegionID);
            builder.HasMany(territory => territory.EmployeeTerritories).WithOne(employeeterritory => employeeterritory.Territory).HasForeignKey(territory => territory.TerritoryID);

            builder.HasData(TerritoryData.Data());
        }
    }
}
