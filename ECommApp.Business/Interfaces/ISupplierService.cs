using System.Collections.Generic;
using ECommApp.Data;

namespace ECommApp.Business.Interfaces
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetSuppliers();
    }
}