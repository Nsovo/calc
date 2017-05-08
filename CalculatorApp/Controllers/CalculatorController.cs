using CalculatorApp.Models;
using CalculatorApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {

        ICalulatorRepository repository = new CalulatorRepository();


        public CalculatorController()
        {
        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculate calc)
        {
            switch (calc.OperatorSelected)
            {
                case "Add" :
                    calc.Answer = repository.Add(calc.Num1, calc.Num2);
                    return View(calc);

                case "Subtract":
                    calc.Answer = repository.Subtract(calc.Num1, calc.Num2);
                    return View(calc);

                case "Multiply":
                    calc.Answer = repository.Multiply(calc.Num1, calc.Num2);
                    return View(calc);

                case "Divide":
                    calc.Answer = repository.Divide(calc.Num1, calc.Num2);
                    return View(calc);
                    
            }

            return View();
        } 


        [HttpPost]
        public ActionResult Clear() {
            //Calculate calc = new Calculate();
            return View();
        }


    }
}