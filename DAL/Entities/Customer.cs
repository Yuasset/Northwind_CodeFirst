using DAL.Abstracts;

namespace DAL.Entities
{
    public class Customer : Base
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        //Mapping
        public List<Order> Orders { get; set; }
        public List<CustomerCustomerDemographic> CustomerCustomerDemographics { get; set; }
    }
}
