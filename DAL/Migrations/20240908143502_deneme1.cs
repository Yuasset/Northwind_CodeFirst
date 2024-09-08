using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDemographics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDemographics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleOfCourtesy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportsTo = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ReportsTo",
                        column: x => x.ReportsTo,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCustomerDemographics",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCustomerDemographics", x => new { x.CustomerID, x.CustomerTypeID });
                    table.ForeignKey(
                        name: "FK_CustomerCustomerDemographics_CustomerDemographics_CustomerTypeID",
                        column: x => x.CustomerTypeID,
                        principalTable: "CustomerDemographics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCustomerDemographics_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipVia = table.Column<int>(type: "int", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipCountry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipVia",
                        column: x => x.ShipVia,
                        principalTable: "Shippers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    QuantityPerUnit = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    UnitsOnOrder = table.Column<int>(type: "int", nullable: false),
                    ReOrderLevel = table.Column<int>(type: "int", nullable: false),
                    Discontinued = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerritories",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    TerritoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerritories", x => new { x.EmployeeID, x.TerritoryID });
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Territories_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Territories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "Description", "Picture" },
                values: new object[] { 1, "Beverages", "Soft drinks, coffees, teas, beers, and ales", "beverages.jpg" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 1, "Obere Str. 57", "Berlin", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Germany", "030-0076545", "030-0074321", "12209", "" },
                    { 2, "Avda. de la Constitución 2222", "México D.F.", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Mexico", "(5) 555-3745", "(5) 555-4729", "05021", "" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "BirthDate", "City", "Country", "Extension", "Firstname", "HireDate", "HomePhone", "Lastname", "Notes", "Photo", "PhotoPath", "PostalCode", "Region", "ReportsTo", "Title", "TitleOfCourtesy" },
                values: new object[] { 2, "908 W. Capital Way", new DateTime(1952, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tacoma", "USA", "3457", "Fuller", new DateTime(1992, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(206) 555-9482", "Andrew", "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.", "", "http://accweb/emmployees/fuller.bmp", "98401", "WA", 2, "Vice President, Sales", "Dr." });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "RegionDescription" },
                values: new object[,]
                {
                    { 1, "Eastern" },
                    { 2, "Western" },
                    { 3, "Northern" },
                    { 4, "Southern" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ID", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "Speedy Express", "(503) 555-9831" },
                    { 2, "United Package", "(503) 555-3199" },
                    { 3, "Federal Shipping", "(503) 555-9931" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "HomePage", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 1, "49 Gilbert St.", "London", "Exotic Liquids", "Charlotte Cooper", "Purchasing Manager", "UK", "", "", "(171) 555-2222", "EC1 4SD", "" },
                    { 2, "P.O. Box 78934", "New Orleans", "New Orleans Cajun Delights", "Shelley Burke", "Order Administrator", "USA", "", "#CAJUN.HTM#", "(100) 555-4822", "70117", "LA" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "BirthDate", "City", "Country", "Extension", "Firstname", "HireDate", "HomePhone", "Lastname", "Notes", "Photo", "PhotoPath", "PostalCode", "Region", "ReportsTo", "Title", "TitleOfCourtesy" },
                values: new object[,]
                {
                    { 1, "507 - 20 Ave. E. Apt. 2A", new DateTime(1948, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "USA", "5467", "Davolio", new DateTime(1992, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(206) 555-9857", "Nancy", "Education includes a BA in psychology from Colorado State University in 1970.  She also completed 'The Art of the Cold Call.'  Nancy is a member of Toastmasters International.", "", "http://accweb/emmployees/davolio.bmp", "98122", "WA", 2, "Sales Representative", "Ms." },
                    { 3, "722 Moss Bay Blvd.", new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kirkland", "USA", "3355", "Leverling", new DateTime(1992, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(206) 555-3412", "Janet", "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.", "", "http://accweb/emmployees/leverling.bmp", "98033", "WA", 2, "Sales Representative", "Ms." },
                    { 4, "4110 Old Redmond Rd.", new DateTime(1937, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Redmond", "USA", "5176", "Peacock", new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(206) 555-8122", "Margaret", "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.", "", "http://accweb/emmployees/peacock.bmp", "98052", "WA", 2, "Sales Representative", "Mrs." },
                    { 5, "14 Garrett Hill", new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "London", "UK", "3453", "Buchanan", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(71) 555-4848", "Steven", "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses 'Successful Telemarketing' and 'International Sales Management.'  He is fluent in French.", "", "http://accweb/emmployees/buchanan.bmp", "SW1 8JR", "", 2, "Sales Manager", "Mr." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Discontinued", "ProductName", "QuantityPerUnit", "ReOrderLevel", "SupplierID", "UnitPrice", "UnitsInStock", "UnitsOnOrder" },
                values: new object[] { 1, 1, 0, "Chai", 10, 10, 1, 18, 39, 0 });

            migrationBuilder.InsertData(
                table: "Territories",
                columns: new[] { "ID", "RegionID", "TerritoryDescription" },
                values: new object[,]
                {
                    { 1581, 1, "Westboro" },
                    { 2116, 1, "Boston" },
                    { 2139, 1, "Cambridge" },
                    { 2184, 1, "Braintree" },
                    { 2186, 1, "Milton" },
                    { 2903, 1, "Providence" },
                    { 3060, 3, "Nashua" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTerritories",
                columns: new[] { "EmployeeID", "TerritoryID" },
                values: new object[,]
                {
                    { 1, 2116 },
                    { 2, 2184 },
                    { 3, 2903 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CustomerID", "EmployeeID", "Freight", "OrderDate", "RequiredDate", "ShipAddress", "ShipCity", "ShipCountry", "ShipName", "ShipPostalCode", "ShipRegion", "ShipVia", "ShippedDate" },
                values: new object[,]
                {
                    { 1, 1, 5, 32.38m, new DateTime(1996, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59 rue de l'Abbaye", "Reims", "France", "Vins et alcools Chevalier", "51100", "", 3, new DateTime(1996, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 4, 65.83m, new DateTime(1996, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua do Paço, 67", "Rio de Janeiro", "Brazil", "Hanari Carnes", "05454-876", "RJ", 2, new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID", "Discount", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, 10 },
                    { 3, 1, 0, 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerDemographics_CustomerTypeID",
                table: "CustomerCustomerDemographics",
                column: "CustomerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerritories_TerritoryID",
                table: "EmployeeTerritories",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeID",
                table: "Orders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipVia",
                table: "Orders",
                column: "ShipVia");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_RegionID",
                table: "Territories",
                column: "RegionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerDemographics");

            migrationBuilder.DropTable(
                name: "EmployeeTerritories");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "CustomerDemographics");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
