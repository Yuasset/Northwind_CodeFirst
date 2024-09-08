using DAL.Abstracts;

namespace DAL.Entities
{
    public class CustomerCustomerDemographic : Base
    {
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }
        //Mapping
        public Customer Customer { get; set; }
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
