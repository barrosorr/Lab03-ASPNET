using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab03_ASPNET.Data;
using Lab03_ASPNET.Models;


namespace Lab03_ASPNET.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly DataAccess dataAccess;

        public HomeController(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            List<YourModel> data = dataAccess.GetData();
            return View(data);

        }
    }
}
