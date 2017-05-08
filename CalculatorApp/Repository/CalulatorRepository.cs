using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculatorApp.Models;

namespace CalculatorApp.Repository
{
    public class CalulatorRepository : ICalulatorRepository
    {

        public CalulatorRepository()
        {
        }

        public int Add(int no1, int no2)
        {
            return (no1 + no2);
        }

        public int Divide(int no1, int no2)
        {
            return (no1 / no2);
        }

        public int Multiply(int no1, int no2)
        {
            return (no1 * no2);
        }

        public int Subtract(int no1, int no2)
        {
            return (no1 - no2);
        }
    }
}