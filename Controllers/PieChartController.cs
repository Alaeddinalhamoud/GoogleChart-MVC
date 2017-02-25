using GoogleChart_MVC.Models;
using GoogleChart_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;

namespace GoogleChart_MVC.Controllers
{
    public class PieChartController : Controller
    {
        private readonly IStudent StudentRepository;
        public PieChartController(IStudent StudentRepo)
        {
            StudentRepository = StudentRepo;
        }
        // GET: PieChart
        public ActionResult Index()
        {
            return View();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public JsonResult GetStudentChart(string aYear)
        {
           
           //Students Pie
            IEnumerable<Student> _SYR = StudentRepository.GetStudents.Where(y => y.Country == "SYR");
            IEnumerable<Student> _USA = StudentRepository.GetStudents.Where(y => y.Country == "USA");
            IEnumerable<Student> _France = StudentRepository.GetStudents.Where(y => y.Country == "France");
            IEnumerable<Student> _UK = StudentRepository.GetStudents.Where(y => y.Country == "UK");
            IEnumerable<Student> _RU = StudentRepository.GetStudents.Where(y => y.Country == "RU");
            IEnumerable<Student> _KSA = StudentRepository.GetStudents.Where(y => y.Country == "KSA");
            IEnumerable<Student> _UAE = StudentRepository.GetStudents.Where(y => y.Country == "UAE");

            
            int SYR_Count = _SYR.Count();
            int USA_Count = _USA.Count();
            int France_Count = _France.Count();
            int UK_Count = _UK.Count();
            int RU_Count = _RU.Count();
            int KSA_Count = _KSA.Count();
            int UAE_Count = _UAE.Count();





             
            var chartData = new object[8];

            chartData[0] = new object[] { "Country", "Number" };
            chartData[1] = new object[] { "SYR", SYR_Count };
            chartData[2] = new object[] { "USA", USA_Count };
            chartData[3] = new object[] { "France", France_Count };
            chartData[4] = new object[] { "UK", UK_Count };
            chartData[5] = new object[] { "RU", RU_Count };
            chartData[6] = new object[] { "KSA", KSA_Count };
            chartData[7] = new object[] { "UAE", UAE_Count };

            // return chartData;
            return Json(chartData, JsonRequestBehavior.AllowGet);
        }


    }
}