using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Calculation
    {
        public static double Plus(double firstOperand,double secondOperand)
        {
            return firstOperand + secondOperand;
        }
        public static double Minus(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
        public static double Division(double firstOperand, double secondOperand)
        {
            return firstOperand / secondOperand;
        }
        public static double Mul(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }
        public static double Div(double firstOperand, double secondOperand)
        {
            return firstOperand % secondOperand;
        }
    }
}
