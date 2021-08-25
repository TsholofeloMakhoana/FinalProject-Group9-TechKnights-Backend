using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Feed
{
    public class ParentRepository : RepositoryBase<ParentData>, IParentRepository
    {
        public SchoolManagementDbConnector _schoolManagementDbConnector;
        public ParentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }

        public List<ParentData> GetParents()
        {
            List<ParentData> parents = null;
            parents = _schoolManagementDbConnector.ParentData.Include("").Select(x => new ParentData()
            {

            }).ToList<ParentData>();
            return parents;

        }
    }

    public class ParentAddressRepository : RepositoryBase<ParentAddressData>, IParentAddressRepository
    {
        public ParentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
