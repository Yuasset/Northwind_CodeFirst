using DAL.Abstracts;

namespace DAL.Entities
{
    public class Region : Base
    {
        public string RegionDescription { get; set; }
        //Mapping
        public List<Territory> Territories { get; set; }
    }
}
