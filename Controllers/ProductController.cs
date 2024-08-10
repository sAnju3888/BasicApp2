using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindDemoEFCoreDependencyInjection2.Models;

namespace NorthwindDemoEFCoreDependencyInjection2.Controllers
    {
    public class ProductController : Controller
        {
        // GET: ProductController
        IProductRepository _productrepo;

        public ProductController(IProductRepository repos)
            {
            _productrepo = repos;
            }
        public ActionResult Index()
            {
            List<ProductModel> list = _productrepo.GetCategories();
            return View(list);
            
            }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
            {
            ProductModel model_obj = _productrepo.GetById(id);
            return View(model_obj);
            }

        // GET: ProductController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }
        }
    }
