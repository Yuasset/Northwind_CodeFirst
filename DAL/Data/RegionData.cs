using DAL.Entities;

namespace DAL.Data
{
    internal class RegionData
    {
        public static List<Region> Data()
        {
            return new List<Region>
            {
                new Region{
                    ID=1,
                    RegionDescription="Eastern"
                    },
                new Region{
                    ID=2,
                    RegionDescription="Western"
                    },
                new Region{
                    ID=3,
                    RegionDescription="Northern"
                    },
                new Region{
                    ID=4,
                    RegionDescription="Southern"
                    }
            };
        }
    }
}
