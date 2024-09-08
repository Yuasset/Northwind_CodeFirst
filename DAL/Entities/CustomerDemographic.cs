using DAL.Abstracts;

namespace DAL.Entities
{
    public class CustomerDemographic : Base
    {
        public string CustomerDescription { get; set; }
        //Mapping
        public List<CustomerCustomerDemographic> CustomerCustomerDemographics { get; set; }
    }
}
