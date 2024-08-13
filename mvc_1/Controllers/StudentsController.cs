using Microsoft.AspNetCore.Mvc;

namespace NorthwindDemoEFCoreDependencyInjection2.Controllers
    {

    public class StudentsController : Controller
        {
        [Route("/stud")]
        public IActionResult Index(int? id)
            {
            if (id.HasValue)
                {
                if (id == 1)
                    {
                    throw new ArgumentNullException("Id is one which is not allowed");
                    }
                else if(id == 2)
                    {
                    return View("InternalServerError");
                    }
                }

            return View();
            }
        }
    }
