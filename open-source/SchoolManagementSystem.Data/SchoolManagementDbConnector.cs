using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class SchoolManagementDbConnector : DbContext
    {
        public SchoolManagementDbConnector(DbContextOptions option) : base(option)
        {

        }

        #region Database Models


        #endregion
    }
}
