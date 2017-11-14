using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommApp.Data;
using ECommApp.Models;

namespace ECommApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //this will be in a service
            IRepo<IList<Supplier>> supplierRepo = new SupplierRepository();
            var allSuppliers = supplierRepo.GetAll();

            IList<SupplierViewModel> listViewModels = new List<SupplierViewModel>();

            if (allSuppliers != null)
            {
                foreach (var supplier in allSuppliers)
                {
                    var viewModel = new SupplierViewModel
                    {
                        Address = supplier.Address
                    };
                    listViewModels.Add(viewModel);
                }
            }
            
            return View(listViewModels);
        }
    }
}