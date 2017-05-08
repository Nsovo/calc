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

            if (calc.Operator == "Add")
                calc.Answer = repository.Add(calc.Num1, calc.num2);
            else if (calc.Operator == "Subtract")
                calc.Answer = repository.Subtract(calc.Num1, calc.num2);
            else if (calc.Operator == "Multiply")
                calc.Answer = repository.Multiply(calc.Num1, calc.num2);
            else if (calc.Operator == "Divide")
                calc.Answer = repository.Divide(calc.Num1, calc.num2);

            return View(calc);
        }


        [HttpPost]
        public ActionResult Clear() {
            Calculate calc = new Calculate();
            return View(calc);
        }


    }
}