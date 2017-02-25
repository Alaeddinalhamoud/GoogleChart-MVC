using GoogleChart_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoogleChart_MVC.Models;

namespace GoogleChart_MVC.Repository
{
    public class SaleAndExpenseRepository : ISaleAndExpense
    {
        public List<SaleAndExpense> GetSales
        { 
          
            get
            {
                List<SaleAndExpense> Sales = new List<SaleAndExpense>();
                Sales.Add(new SaleAndExpense() {  SaleId=1,  TotalSale=100 ,TotalExpense=10,Year="2010" });
                Sales.Add(new SaleAndExpense() { SaleId = 2, TotalSale = 100,TotalExpense=50, Year = "2011" });
                Sales.Add(new SaleAndExpense() { SaleId = 3, TotalSale = 300,TotalExpense=20, Year = "2012" });
                Sales.Add(new SaleAndExpense() { SaleId = 4, TotalSale = 500,TotalExpense=40, Year = "2013" });
                Sales.Add(new SaleAndExpense() { SaleId = 5, TotalSale = 700,TotalExpense=60, Year = "2014" });
                Sales.Add(new SaleAndExpense() { SaleId = 6, TotalSale = 50,TotalExpense=100, Year = "2015" });
                Sales.Add(new SaleAndExpense() { SaleId = 7, TotalSale = 500,TotalExpense=10, Year = "2016" });
                Sales.Add(new SaleAndExpense() { SaleId = 8, TotalSale = 1000,TotalExpense=500, Year = "2017" });

                return Sales;
            }
        }
    }
}