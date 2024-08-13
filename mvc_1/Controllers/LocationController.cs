using Microsoft.AspNetCore.Mvc;

namespace NorthwindDemoEFCoreDependencyInjection2.Controllers
    {
    public class LocationController : Controller
        {
        public IActionResult Index()
            {
            return View();
            }

        public async Task<IActionResult> GetListAsnchronously()

            {
            var CountryName = await GetCountryViaAsync();
            ViewBag.cn = CountryName;
            return View();
            }

        public ActionResult GetList()
            {
            var countryname = GetCountry();
            ViewBag.cm = countryname;
            return View();
            }

        [NonAction]
        public string GetCountry()
            {

            Thread.Sleep(2000);
            return "India";
            }
        [NonAction]
        public async Task<string> GetCountryViaAsync()
            {
            await Task.Delay(2000);
            return "India";
            }
        }
    }
