using DAL.Abstracts;

namespace DAL.Entities
{
    public class EmployeeTerritory : Base
    {
        public int EmployeeID { get; set; }
        public int TerritoryID { get; set; }
        //Mapping
        public Employee Employee { get; set; }
        public Territory Territory { get; set; }
    }
}
