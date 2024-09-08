﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    partial class NorthwindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Beverages",
                            Description = "Soft drinks, coffees, teas, beers, and ales",
                            Picture = "beverages.jpg"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Obere Str. 57",
                            City = "Berlin",
                            CompanyName = "Alfreds Futterkiste",
                            ContactName = "Maria Anders",
                            ContactTitle = "Sales Representative",
                            Country = "Germany",
                            Fax = "030-0076545",
                            Phone = "030-0074321",
                            PostalCode = "12209",
                            Region = ""
                        },
                        new
                        {
                            ID = 2,
                            Address = "Avda. de la Constitución 2222",
                            City = "México D.F.",
                            CompanyName = "Ana Trujillo Emparedados y helados",
                            ContactName = "Ana Trujillo",
                            ContactTitle = "Owner",
                            Country = "Mexico",
                            Fax = "(5) 555-3745",
                            Phone = "(5) 555-4729",
                            PostalCode = "05021",
                            Region = ""
                        });
                });

            modelBuilder.Entity("DAL.Entities.CustomerCustomerDemographic", b =>
                {
                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID", "CustomerTypeID");

                    b.HasIndex("CustomerTypeID");

                    b.ToTable("CustomerCustomerDemographics");
                });

            modelBuilder.Entity("DAL.Entities.CustomerDemographic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CustomerDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("DAL.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportsTo")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "507 - 20 Ave. E. Apt. 2A",
                            BirthDate = new DateTime(1948, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Seattle",
                            Country = "USA",
                            Extension = "5467",
                            Firstname = "Davolio",
                            HireDate = new DateTime(1992, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomePhone = "(206) 555-9857",
                            Lastname = "Nancy",
                            Notes = "Education includes a BA in psychology from Colorado State University in 1970.  She also completed 'The Art of the Cold Call.'  Nancy is a member of Toastmasters International.",
                            Photo = "",
                            PhotoPath = "http://accweb/emmployees/davolio.bmp",
                            PostalCode = "98122",
                            Region = "WA",
                            ReportsTo = 2,
                            Title = "Sales Representative",
                            TitleOfCourtesy = "Ms."
                        },
                        new
                        {
                            ID = 2,
                            Address = "908 W. Capital Way",
                            BirthDate = new DateTime(1952, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Tacoma",
                            Country = "USA",
                            Extension = "3457",
                            Firstname = "Fuller",
                            HireDate = new DateTime(1992, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomePhone = "(206) 555-9482",
                            Lastname = "Andrew",
                            Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",
                            Photo = "",
                            PhotoPath = "http://accweb/emmployees/fuller.bmp",
                            PostalCode = "98401",
                            Region = "WA",
                            ReportsTo = 2,
                            Title = "Vice President, Sales",
                            TitleOfCourtesy = "Dr."
                        },
                        new
                        {
                            ID = 3,
                            Address = "722 Moss Bay Blvd.",
                            BirthDate = new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Kirkland",
                            Country = "USA",
                            Extension = "3355",
                            Firstname = "Leverling",
                            HireDate = new DateTime(1992, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomePhone = "(206) 555-3412",
                            Lastname = "Janet",
                            Notes = "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.",
                            Photo = "",
                            PhotoPath = "http://accweb/emmployees/leverling.bmp",
                            PostalCode = "98033",
                            Region = "WA",
                            ReportsTo = 2,
                            Title = "Sales Representative",
                            TitleOfCourtesy = "Ms."
                        },
                        new
                        {
                            ID = 4,
                            Address = "4110 Old Redmond Rd.",
                            BirthDate = new DateTime(1937, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Redmond",
                            Country = "USA",
                            Extension = "5176",
                            Firstname = "Peacock",
                            HireDate = new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomePhone = "(206) 555-8122",
                            Lastname = "Margaret",
                            Notes = "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.",
                            Photo = "",
                            PhotoPath = "http://accweb/emmployees/peacock.bmp",
                            PostalCode = "98052",
                            Region = "WA",
                            ReportsTo = 2,
                            Title = "Sales Representative",
                            TitleOfCourtesy = "Mrs."
                        },
                        new
                        {
                            ID = 5,
                            Address = "14 Garrett Hill",
                            BirthDate = new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "London",
                            Country = "UK",
                            Extension = "3453",
                            Firstname = "Buchanan",
                            HireDate = new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomePhone = "(71) 555-4848",
                            Lastname = "Steven",
                            Notes = "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses 'Successful Telemarketing' and 'International Sales Management.'  He is fluent in French.",
                            Photo = "",
                            PhotoPath = "http://accweb/emmployees/buchanan.bmp",
                            PostalCode = "SW1 8JR",
                            Region = "",
                            ReportsTo = 2,
                            Title = "Sales Manager",
                            TitleOfCourtesy = "Mr."
                        });
                });

            modelBuilder.Entity("DAL.Entities.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "TerritoryID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("EmployeeTerritories");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            TerritoryID = 2116
                        },
                        new
                        {
                            EmployeeID = 2,
                            TerritoryID = 2184
                        },
                        new
                        {
                            EmployeeID = 3,
                            TerritoryID = 2903
                        });
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Freight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipVia")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CustomerID = 1,
                            EmployeeID = 5,
                            Freight = 32.38m,
                            OrderDate = new DateTime(1996, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequiredDate = new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShipAddress = "59 rue de l'Abbaye",
                            ShipCity = "Reims",
                            ShipCountry = "France",
                            ShipName = "Vins et alcools Chevalier",
                            ShipPostalCode = "51100",
                            ShipRegion = "",
                            ShipVia = 3,
                            ShippedDate = new DateTime(1996, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CustomerID = 2,
                            EmployeeID = 4,
                            Freight = 65.83m,
                            OrderDate = new DateTime(1996, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequiredDate = new DateTime(1996, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShipAddress = "Rua do Paço, 67",
                            ShipCity = "Rio de Janeiro",
                            ShipCountry = "Brazil",
                            ShipName = "Hanari Carnes",
                            ShipPostalCode = "05454-876",
                            ShipRegion = "RJ",
                            ShipVia = 2,
                            ShippedDate = new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DAL.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            ProductID = 1,
                            Discount = 0,
                            Quantity = 1,
                            UnitPrice = 10
                        },
                        new
                        {
                            OrderID = 3,
                            ProductID = 1,
                            Discount = 0,
                            Quantity = 3,
                            UnitPrice = 10
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("Discontinued")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<int>("ReOrderLevel")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Discontinued = 0,
                            ProductName = "Chai",
                            QuantityPerUnit = 10,
                            ReOrderLevel = 10,
                            SupplierID = 1,
                            UnitPrice = 18,
                            UnitsInStock = 39,
                            UnitsOnOrder = 0
                        });
                });

            modelBuilder.Entity("DAL.Entities.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            RegionDescription = "Eastern"
                        },
                        new
                        {
                            ID = 2,
                            RegionDescription = "Western"
                        },
                        new
                        {
                            ID = 3,
                            RegionDescription = "Northern"
                        },
                        new
                        {
                            ID = 4,
                            RegionDescription = "Southern"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Shipper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shippers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CompanyName = "Speedy Express",
                            Phone = "(503) 555-9831"
                        },
                        new
                        {
                            ID = 2,
                            CompanyName = "United Package",
                            Phone = "(503) 555-3199"
                        },
                        new
                        {
                            ID = 3,
                            CompanyName = "Federal Shipping",
                            Phone = "(503) 555-9931"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "49 Gilbert St.",
                            City = "London",
                            CompanyName = "Exotic Liquids",
                            ContactName = "Charlotte Cooper",
                            ContactTitle = "Purchasing Manager",
                            Country = "UK",
                            Fax = "",
                            HomePage = "",
                            Phone = "(171) 555-2222",
                            PostalCode = "EC1 4SD",
                            Region = ""
                        },
                        new
                        {
                            ID = 2,
                            Address = "P.O. Box 78934",
                            City = "New Orleans",
                            CompanyName = "New Orleans Cajun Delights",
                            ContactName = "Shelley Burke",
                            ContactTitle = "Order Administrator",
                            Country = "USA",
                            Fax = "",
                            HomePage = "#CAJUN.HTM#",
                            Phone = "(100) 555-4822",
                            PostalCode = "70117",
                            Region = "LA"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Territory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RegionID");

                    b.ToTable("Territories");

                    b.HasData(
                        new
                        {
                            ID = 1581,
                            RegionID = 1,
                            TerritoryDescription = "Westboro"
                        },
                        new
                        {
                            ID = 2116,
                            RegionID = 1,
                            TerritoryDescription = "Boston"
                        },
                        new
                        {
                            ID = 2139,
                            RegionID = 1,
                            TerritoryDescription = "Cambridge"
                        },
                        new
                        {
                            ID = 2184,
                            RegionID = 1,
                            TerritoryDescription = "Braintree"
                        },
                        new
                        {
                            ID = 2186,
                            RegionID = 1,
                            TerritoryDescription = "Milton"
                        },
                        new
                        {
                            ID = 2903,
                            RegionID = 1,
                            TerritoryDescription = "Providence"
                        },
                        new
                        {
                            ID = 3060,
                            RegionID = 3,
                            TerritoryDescription = "Nashua"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CustomerCustomerDemographic", b =>
                {
                    b.HasOne("DAL.Entities.Customer", "Customer")
                        .WithMany("CustomerCustomerDemographics")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.CustomerDemographic", "CustomerDemographic")
                        .WithMany("CustomerCustomerDemographics")
                        .HasForeignKey("CustomerTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("CustomerDemographic");
                });

            modelBuilder.Entity("DAL.Entities.Employee", b =>
                {
                    b.HasOne("DAL.Entities.Employee", "Nagivation")
                        .WithMany("Employees")
                        .HasForeignKey("ReportsTo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Nagivation");
                });

            modelBuilder.Entity("DAL.Entities.EmployeeTerritory", b =>
                {
                    b.HasOne("DAL.Entities.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.HasOne("DAL.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("DAL.Entities.OrderDetail", b =>
                {
                    b.HasOne("DAL.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DAL.Entities.Territory", b =>
                {
                    b.HasOne("DAL.Entities.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Navigation("CustomerCustomerDemographics");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DAL.Entities.CustomerDemographic", b =>
                {
                    b.Navigation("CustomerCustomerDemographics");
                });

            modelBuilder.Entity("DAL.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeTerritories");

                    b.Navigation("Employees");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DAL.Entities.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("DAL.Entities.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DAL.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Entities.Territory", b =>
                {
                    b.Navigation("EmployeeTerritories");
                });
#pragma warning restore 612, 618
        }
    }
}
