using DAL.Entities;

namespace DAL.Data
{
    internal class EmployeeData
    {
        public static List<Employee> Data()
        {
            return new List<Employee>
            {
                new Employee
                {
                    ID = 1,
                    Firstname = "Davolio",
                    Lastname = "Nancy",
                    Title = "Sales Representative",
                    TitleOfCourtesy = "Ms.",
                    BirthDate = new DateTime(1948, 12, 8),
                    HireDate = new DateTime(1992, 5, 1),
                    Address = "507 - 20 Ave. E. Apt. 2A",
                    City = "Seattle",
                    Region = "WA",
                    PostalCode = "98122",
                    Country = "USA",
                    HomePhone = "(206) 555-9857",
                    Extension = "5467",
                    Photo = "",
                    Notes = "Education includes a BA in psychology from Colorado State University in 1970.  She also completed 'The Art of the Cold Call.'  Nancy is a member of Toastmasters International.",
                    ReportsTo = 2,
                    PhotoPath = "http://accweb/emmployees/davolio.bmp"
                },
                new Employee
                {
                    ID = 2,
                    Firstname = "Fuller",
                    Lastname = "Andrew",
                    Title = "Vice President, Sales",
                    TitleOfCourtesy = "Dr.",
                    BirthDate = new DateTime(1952, 2, 19),
                    HireDate = new DateTime(1992, 8, 14),
                    Address = "908 W. Capital Way",
                    City = "Tacoma",
                    Region = "WA",
                    PostalCode = "98401",
                    Country = "USA",
                    HomePhone = "(206) 555-9482",
                    Extension = "3457",
                    Photo = "",
                    Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",
                    ReportsTo = 2,
                    PhotoPath = "http://accweb/emmployees/fuller.bmp"
                },
                new Employee
                {
                    ID = 3,
                    Firstname = "Leverling",
                    Lastname = "Janet",
                    Title = "Sales Representative",
                    TitleOfCourtesy = "Ms.",
                    BirthDate = new DateTime(1963, 8, 30),
                    HireDate = new DateTime(1992, 4, 1),
                    Address = "722 Moss Bay Blvd.",
                    City = "Kirkland",
                    Region = "WA",
                    PostalCode = "98033",
                    Country = "USA",
                    HomePhone = "(206) 555-3412",
                    Extension = "3355",
                    Photo = "",
                    Notes = "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.",
                    ReportsTo = 2,
                    PhotoPath = "http://accweb/emmployees/leverling.bmp"
                },
                new Employee
                {
                    ID = 4,
                    Firstname = "Peacock",
                    Lastname = "Margaret",
                    Title = "Sales Representative",
                    TitleOfCourtesy = "Mrs.",
                    BirthDate = new DateTime(1937, 9, 19),
                    HireDate = new DateTime(1993, 5, 3),
                    Address = "4110 Old Redmond Rd.",
                    City = "Redmond",
                    Region = "WA",
                    PostalCode = "98052",
                    Country = "USA",
                    HomePhone = "(206) 555-8122",
                    Extension = "5176",
                    Photo = "",
                    Notes = "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.",
                    ReportsTo = 2,
                    PhotoPath = "http://accweb/emmployees/peacock.bmp"
                },
                new Employee
                {
                    ID = 5,
                    Firstname = "Buchanan",
                    Lastname = "Steven",
                    Title = "Sales Manager",
                    TitleOfCourtesy = "Mr.",
                    BirthDate = new DateTime(1955, 3, 4),
                    HireDate = new DateTime(1993, 10, 17),
                    Address = "14 Garrett Hill",
                    City = "London",
                    Region = "",
                    PostalCode = "SW1 8JR",
                    Country = "UK",
                    HomePhone = "(71) 555-4848",
                    Extension = "3453",
                    Photo = "",
                    Notes = "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses 'Successful Telemarketing' and 'International Sales Management.'  He is fluent in French.",
                    ReportsTo = 2,
                    PhotoPath = "http://accweb/emmployees/buchanan.bmp"
                }
            };
        }
    }
}
