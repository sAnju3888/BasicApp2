using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindDemoEFCoreDependencyInjection2.Models;

namespace NorthwindDemoEFCoreDependencyInjection2.Controllers
    {

    [Route("tes")]
    public class EmployeesController : Controller
        {
        // GET: EmployeesController

        public ActionResult Index()
            {
            return View();
            }



      
        [Route("/Details/{id}")]
        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
            {
            return Content("Details");
            }
        [Route("/{id}/Create")]
        // GET: EmployeesController/Create
        public ActionResult Create()
            {
            return Content("Create");
            }

        // POST: EmployeesController/Create
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

        // GET: EmployeesController/Edit/5
        [Route("/{id}")]
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: EmployeesController/Edit/5
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

        // GET: EmployeesController/Delete/5
        [Route("/details/delete/{id}")]
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: EmployeesController/Delete/5
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
