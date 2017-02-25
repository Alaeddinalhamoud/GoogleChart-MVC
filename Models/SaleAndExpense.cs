using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleChart_MVC.Models
{
    public class SaleAndExpense
    {
        public int SaleId { get; set; }

        public int TotalSale { get; set; }
        public int TotalExpense { get; set; }
        public string Year { get; set; }
    }
}