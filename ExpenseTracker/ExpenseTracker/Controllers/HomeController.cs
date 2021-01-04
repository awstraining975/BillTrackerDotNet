using ExpenseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your test.";

            var lines = System.IO.File.ReadAllLines(@"C:\Users\billy\Desktop\New folder\DataBase.txt");
            Expense e = new Expense();
            foreach (string line in lines)
            {
                string[] items = line.Split(' ');


                
                e.Name = items[0];
                e.Value = Convert.ToDouble(items[1]);
                break;
            }



            //DueDateInformation d = new DueDateInformation();
            //d.DueDate = new DateTime(2021, 2, 3);
            //d.Penalty = 35;

            //e.DueDateInfo = d;

            return View(e);
        }
    }
}