using DAL.Abstracts;

namespace DAL.Entities
{
    public class Shipper : Base
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        //Mapping
        public List<Order> Orders { get; set; }
    }
}
