using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class EmployeeTerritoryConfiguration : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.Ignore(employeeterritory => employeeterritory.ID);
            builder.HasKey(employeeterritory => new { employeeterritory.EmployeeID, employeeterritory.TerritoryID });

            builder.HasData(EmployeeTerritoryData.Data());

        }
    }
}
