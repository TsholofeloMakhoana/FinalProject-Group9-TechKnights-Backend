using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class RepositoryBase<T> where T : class
    {
        private readonly SchoolManagementDbConnector _dbConnector;
        public RepositoryBase(SchoolManagementDbConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }


        public T Create(T tentity)
        {
            return null;
        }
        public T Update(T tentity)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }

        public T GetById(int id)
        {
            return null;
        }
    }
}
