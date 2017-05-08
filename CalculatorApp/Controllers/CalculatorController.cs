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
           
            if (calc.result ==0)
               calc.answer = repository.Add(calc.num1, calc.num2);
            else if(calc.result == 1)
                calc.answer = repository.Subtract(calc.num1, calc.num2);
            else if (calc.result == 2 )
                calc.answer = repository.Multiply(calc.num1, calc.num2);
            else if (calc.result == 3)
                calc.answer = repository.Divide(calc.num1, calc.num2);

            return View("Index", calc);
        }

    
    }
}