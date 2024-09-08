using DAL.Abstracts;

namespace DAL.Entities
{
    public class Employee : Base
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        //Mapping
        public List<EmployeeTerritory> EmployeeTerritories { get; set; }
        public Employee Nagivation { get; set; } //todo: Hocaya sorulacak
        public List<Employee> Employees { get; set; }
        public List<Order> Orders { get; set; }
    }
}
