
using System.Collections.Generic;

namespace SchoolManagementSystem.Data
{
    public interface IRepositoryBase<T>  where T : class
    {
        T Create(T tentity);

        void Update();

        bool Delete(int id);

        T GetById(int id);

        List<T> GetList();
    }
}
