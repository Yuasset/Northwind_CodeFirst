using DAL.Abstracts;
namespace BLL.Service
{
    internal interface ICRUD<T> where T : Base
    {
        List<T> Read();
        T ReadByID(int id);
        string Create(T model);
        string Update(T model);
        string Delete(int id);
    }
}
