using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        //method for addition
        public double Add(double left, double right)
        {
            return left + right;
        }
        //method for subtraction
        public double Subtract(double left, double right)
        {
            return left - right;
        }
        //method for division
        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();
            }
            
        }
        //method for multiplication
        public double Multiply(double left, double right)
        {
            if (right == 0 || left == 0)
            {
                return 0;
            }
            else
            {
                return left * right;
            }

        }
    }
}
