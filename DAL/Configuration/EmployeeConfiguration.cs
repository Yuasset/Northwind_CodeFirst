using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).UseIdentityColumn();
            //todo: Hocaya sorulacak
            builder.HasOne(emplooye => emplooye.Nagivation).WithMany(employee => employee.Employees).HasForeignKey(employee => employee.ReportsTo).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(employee => employee.EmployeeTerritories).WithOne(employeeterritories => employeeterritories.Employee).HasForeignKey(employee => employee.EmployeeID);

            builder.HasData(EmployeeData.Data());
        }
    }
}
