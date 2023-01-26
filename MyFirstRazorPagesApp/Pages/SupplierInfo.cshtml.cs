using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstRazorPagesApp.Models;

namespace MyFirstRazorPagesApp.Pages
{
    public class SupplierInfoModel : PageModel
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }

        private readonly NorthwindContext _dbContext;

        public SupplierInfoModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet(int suppId)
        {
            var supplierInfo = _dbContext.Suppliers.First(s=>s.SupplierId == suppId);
            CompanyName = supplierInfo.CompanyName;
            ContactName = supplierInfo.ContactName;
            City = supplierInfo.City;
        }
    }
}
