using DAL.Entities;

namespace DAL.Data
{
    internal class TerritoryData
    {
        public static List<Territory> Data()
        {
            return new List<Territory>
            {
                new Territory
                {
                    ID = 01581,
                    TerritoryDescription = "Westboro",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 02116,
                    TerritoryDescription = "Boston",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 02139,
                    TerritoryDescription = "Cambridge",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 02184,
                    TerritoryDescription = "Braintree",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 02186,
                    TerritoryDescription = "Milton",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 02903,
                    TerritoryDescription = "Providence",
                    RegionID = 1
                },
                new Territory
                {
                    ID = 03060,
                    TerritoryDescription = "Nashua",
                    RegionID = 3
                },
            };
        }
    }
}
