using BookSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository _repository;

        public NavigationMenuViewComponent(IBookRepository repo)
        {
            _repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.BookShelf
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
