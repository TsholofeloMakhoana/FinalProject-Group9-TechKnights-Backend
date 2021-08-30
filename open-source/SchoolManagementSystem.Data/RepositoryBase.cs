

using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Data
{
    public class RepositoryBase<T> where T : class
    {

        #region ctr
        private readonly SchoolManagementDbConnector _dbConnector;
        public RepositoryBase(SchoolManagementDbConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }
        #endregion


        public T Create(T tentity)
        {
            var saveEntityData = _dbConnector.Set<T>().Add(tentity);
            if (saveEntityData != null)
            {
                if (_dbConnector.SaveChanges() > 0)
                    return tentity;
            }
            return null;
        }
        public object Update(T tentity)
        {
            return _dbConnector.Set<T>().Update(tentity);
        }
        public bool Delete(int id)
        {
            var sqlDelete = GetById(id);
            if (sqlDelete != null)
            {
                _dbConnector.Set<T>().Remove(sqlDelete);
                return true;
            }
            return false;
        }
        public T GetById(int id)
        {
            return _dbConnector.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _dbConnector.Set<T>().ToList();
        }
    }
}
