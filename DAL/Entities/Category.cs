using DAL.Abstracts;

namespace DAL.Entities
{
    public class Category : Base
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        //Mapping
        public List<Product> Products { get; set; }
    }
}
