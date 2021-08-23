
namespace SchoolManagementSystem.Data
{
    public interface IRepositoryBase<T>  where T : class
    {
        T Create(T tentity);

        object Update(T tentity);

        bool Delete(int id);

        T GetById(int id);
    }
}
