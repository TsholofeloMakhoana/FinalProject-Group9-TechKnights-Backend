using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;
namespace SchoolManagementSystem.Feed
{
   public class InvoiceRepository : RepositoryBase<InvoiceData>, IInvoiceRepository
    {

        #region ctr
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public InvoiceRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

        public List<InvoiceDataViewModel> GetInvoiceById(int id)
        {
            List<InvoiceDataViewModel> sqlGet = new List<InvoiceDataViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.InvoiceData
                      where m.StudentId == id
                      select new InvoiceDataViewModel
                      {
                          InvoiceId = m.InvoiceId,
                          StudentId = m.StudentId,
                          Title = m.Title,
                          Description = m.Description,
                          Amount = m.Amount,
                          Due = m.Due,
                          AmountPaid = m.AmountPaid,
                          Status = m.Status,
                          PaymentMethod = m.PaymentMethod,
                          DatePaid = m.DatePaid
                      }).ToList();

            return sqlGet;
        }
    }
}
