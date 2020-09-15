using Microsoft.AspNetCore.Mvc;
using ElectronicProducts.Models;
using System.Linq;
using ElectronicProducts.Models.ViewModels;

namespace ElectronicProducts.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRespository repository;
        public int PageSize = 4;

        public HomeController(IStoreRespository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
           => View(new ProductsListViewModel
           {
               Products = repository.Products
                   .Where(p => category ==null || p.Category == category)
                   .OrderBy(p => p.ProductID)
                   .Skip((productPage - 1) * PageSize)
                   .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
               },
               CurrentCategory = category
           });
    }
}