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
    public class BarChartController : Controller
    {
        private readonly ISaleAndExpense SaleRepository;
    


        public BarChartController(ISaleAndExpense SaleRepo )
        {
            SaleRepository = SaleRepo;
         
        }
        // GET: GoogleChart
        public ActionResult Index()
        {
            return View();
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public JsonResult GetBarChartSalesAndExpenses()
        {
            

            List<SaleAndExpense> Sales = SaleRepository.GetSales;
           
           

            var chartData = new object[Sales.Count + 1];

            chartData[0] = new object[]{
                    "Year",
                    "Sales",
                    "Expenses"
                };

            int j = 0;
            foreach (var i in Sales)
            {
                j++;
                chartData[j] = new object[] { i.Year, i.TotalSale, i.TotalExpense };
            }


            return Json(chartData, JsonRequestBehavior.AllowGet);
        }
    }
}