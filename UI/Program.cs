using BLL.Service;
using DAL.Entities;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD<Category> categoryCRUD = new CRUD<Category>();

            //categoryCRUD.Create(new Category { CategoryName = "Muz", Description = "Tatlıdır ama sindirimi yavaşlatır", Picture = "" });

            foreach (var item in categoryCRUD.Read())
            {
                Console.WriteLine($"ID: {item.ID}, Kategori: {item.CategoryName}, Açıklama: {item.Description}, Görsel: {item.Picture}");
            }
            Console.WriteLine(categoryCRUD.ReadByID(1).CategoryName);

            categoryCRUD.Update(new Category { ID = 1, CategoryName = "Elma", Description="Meyvedir yenir", Picture=""});

            Console.WriteLine(categoryCRUD.ReadByID(1).CategoryName);
        }
    }
}