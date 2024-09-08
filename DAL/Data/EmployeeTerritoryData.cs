using DAL.Entities;

namespace DAL.Data
{
    internal class EmployeeTerritoryData
    {
        public static List<EmployeeTerritory> Data()
        {
            return new List<EmployeeTerritory>
            {
                new EmployeeTerritory
                {
                    EmployeeID = 1,
                    TerritoryID = 02116
                },
                new EmployeeTerritory
                {
                    EmployeeID = 2,
                    TerritoryID = 02184
                },
                new EmployeeTerritory
                {
                    EmployeeID = 3,
                    TerritoryID = 02903
                }
            };
        }
    }
}
