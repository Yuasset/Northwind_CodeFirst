using DAL.Abstracts;
using DAL.Context;

namespace BLL.Service
{
    public class CRUD<T> : ICRUD<T> where T : Base
    {
        NorthwindContext dbcontext = new NorthwindContext();
        public string Create(T model)
        {
            dbcontext.Set<T>().Add(model);
            dbcontext.SaveChanges();
            return "Veri Kaydedildi";
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> Read()
        {
            var list = dbcontext.Set<T>().ToList();
            return new List<T>(list);
        }

        public T ReadByID(int id)
        {
            return dbcontext.Set<T>().Find(id);
        }

        public string Update(T model)
        {
            try
            {
                T entity = dbcontext.Set<T>().Find(model.ID);

                if (entity != null)
                {
                    dbcontext.Entry(entity).CurrentValues.SetValues(model);
                    dbcontext.SaveChanges();
                    return "Güncelleme başarılı";
                }
                else
                {
                    return "Güncelleme başarısız";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
