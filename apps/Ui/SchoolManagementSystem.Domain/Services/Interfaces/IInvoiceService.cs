

using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IInvoiceService 
    {
        List<InvoiceDataViewModel> GetInvoiceById(int id);
        string CreateInvoice(InvoiceDataViewModel model);
    }
}
