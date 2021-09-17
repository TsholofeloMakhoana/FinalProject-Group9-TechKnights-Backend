

using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IInvoiceRepository : IRepositoryBase<InvoiceData>
    {
        List<InvoiceDataViewModel> GetInvoiceById(int id);
    }
}
