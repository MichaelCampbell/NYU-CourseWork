using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class StoreController : Controller
    {
        public int PageSize = 3;
        private IStoreRepository repository;

        public StoreController(IStoreRepository storeRepository)
        {
            repository = storeRepository;
        }

        public ActionResult List(int page = 1)
        {
            var stores = repository.Stores.OrderBy(s => s.StoreID).Skip((page - 1)*PageSize).Take(PageSize);

            var model = new StoresListViewModel
            {
                Stores = stores,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    TotalItems = repository.Stores.Count(),
                    ItemsPerPage = PageSize
                }
            };
            return View(model);
        }

    }
}
