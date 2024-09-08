using DAL.Entities;

namespace DAL.Data
{
    internal class CategoryData
    {
        public static List<Category> Data()
        {
            return new List<Category>{
                new Category{
                ID=1,
                CategoryName="Beverages",
                Description="Soft drinks, coffees, teas, beers, and ales",
                Picture="beverages.jpg"
                }};
        }
    }
}
