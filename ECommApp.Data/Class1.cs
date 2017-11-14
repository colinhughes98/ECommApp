using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommApp.Data
{

    public interface IRepo<out T>
    {
        T GetAll();
    }

    public class SupplierRepository : DbContext, IRepo<IList<Supplier>>
    {
        public IList<Supplier> GetAll()
        {
            using (var db = new NorthwindEntities())
            {
                return db.Suppliers.Select(a => a).ToList();
            }
        }
    }
}
