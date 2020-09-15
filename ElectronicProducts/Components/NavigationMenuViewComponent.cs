using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ElectronicProducts.Models;

namespace ElectronicProducts.Components {

    public class NavigationMenuViewComponent : ViewComponent {
        private IStoreRespository repository;

        public NavigationMenuViewComponent(IStoreRespository repo) {
            repository = repo;
        }

        public IViewComponentResult Invoke() {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
