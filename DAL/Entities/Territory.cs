using DAL.Abstracts;

namespace DAL.Entities
{
    public class Territory : Base
    {
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        //Mapping
        public Region Region { get; set; }
        public List<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
