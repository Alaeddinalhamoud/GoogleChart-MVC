using GoogleChart_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleChart_MVC.Controllers
{
    public class GoogleChartController : Controller
    {
        private readonly IStudent StudentRepository;
        public GoogleChartController(IStudent StudentRepo)
        {
            StudentRepository = StudentRepo;
        }
        // GET: GoogleChart
        public ActionResult Index()
        {
            return View();
        }
    }
}