using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindDemoEFCoreDependencyInjection2.Models;

namespace NorthwindDemoEFCoreDependencyInjection2.Controllers
    {
    public class CategoriesController : Controller
        {
        // GET: CategoriesController
        ICategoryRepository _categoryrepo;

        
        public CategoriesController(ICategoryRepository repository)
            {
            _categoryrepo = repository;
            }

        [Route("/joker")]
        public ActionResult Simply()
            {
            return Content("This string has id");
            }
        [Route("Cat/All")]
        public ActionResult Index()
            {
            List<CategoryModel> list = _categoryrepo.GetCategories();
            return View(list);
            }

        // GET: CategoriesController/Details/5
        [Route("CatModel/{id}")]
        public ActionResult Details(int id)
            
            {

            CategoryModel model = _categoryrepo.GetById(id);
            return View(model);
            }

        // GET: CategoriesController/Create
        [Route("/new")]
        public ActionResult Create()
            {
            return View();
            }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
            {
            try
                {
                CategoryModel model = new CategoryModel();
                model.CategoryName = collection["CategoryName"].ToString();
                model.Description = collection["Description"].ToString();
                _categoryrepo.Add(model);

                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: CategoriesController/Edit/5
        [Route("/Edit/{id}")]
        public ActionResult Edit(int id)
            {
            CategoryModel m = _categoryrepo.GetById(id);

            return View(m);
            }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
            {
            try
                {
                
                CategoryModel category = new CategoryModel();
                category.CategoryName = collection["CategoryName"].ToString();
                category.Description = collection["Description"].ToString();

                
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: CategoriesController/Delete/5
        [Route("/Delete/{id}")]
        public ActionResult Delete(int id)
            {
            CategoryModel m = _categoryrepo.GetById(id);
            return View(m);
            }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
            {
            try
                {
                CategoryModel model = new CategoryModel();
                model.CategoryId = id;
         model= _categoryrepo.GetById(id);
              
                _categoryrepo.Delete(model);
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }
        }
    }
