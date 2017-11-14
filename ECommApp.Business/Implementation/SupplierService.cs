using System.Collections.Generic;
using ECommApp.Business.Interfaces;
using ECommApp.Data;

namespace ECommApp.Business.Implementation
{
    public class SupplierService : ISupplierService
    {
        //DI
        readonly IRepo<IList<Supplier>> _supplierRepo = new SupplierRepository();
        public IEnumerable<Supplier> GetSuppliers()
        {
            return _supplierRepo.GetAll();
        }
    }
}
