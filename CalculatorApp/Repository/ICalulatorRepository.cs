using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorApp.Repository
{
    public interface ICalulatorRepository
    {
        int Add(int no1, int no2);
        int Subtract(int no1, int no2);
        int Multiply(int no1, int no2);
        int Divide(int no1, int no2);
    }
}