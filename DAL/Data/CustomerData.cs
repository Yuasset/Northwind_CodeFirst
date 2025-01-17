﻿using DAL.Entities;

namespace DAL.Data
{
    internal class CustomerData
    {
        public static List<Customer> Data()
        {
            return new List<Customer>
            {
                new Customer
                {
                    ID = 1,
                    CompanyName = "Alfreds Futterkiste",
                    ContactName = "Maria Anders",
                    ContactTitle = "Sales Representative",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    Region = "",
                    PostalCode = "12209",
                    Country = "Germany",
                    Phone = "030-0074321",
                    Fax = "030-0076545"
                    },
                new Customer
                {
                    ID = 2,
                    CompanyName = "Ana Trujillo Emparedados y helados",
                    ContactName = "Ana Trujillo",
                    ContactTitle = "Owner",
                    Address = "Avda. de la Constitución 2222",
                    City = "México D.F.",
                    Region = "",
                    PostalCode = "05021",
                    Country = "Mexico",
                    Phone = "(5) 555-4729",
                    Fax = "(5) 555-3745"
                }
            };
        }
    }
}
