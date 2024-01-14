using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maths
{
    public class AdvMath
    {

        
        public double CalcArea(double num1, double num2)
        {
            return num1 * num2;
        }

        public double CalcAvg(List<double> lNums)
        {
            double sum = 0; // initiate 

            // loop , get sum, then div by amnt for avg.
            foreach (double num in lNums)
            {
                sum += num;
            }

            return sum / lNums.Count;
        }

        public double CalcNumSq(double num)
        {
            return num * num;
        }

        // I think you wanted us to sqR it as well?
        public double CalcNumSqrt(double num)
        {
            return Math.Sqrt(num);
        }

        public double CalcPT(double a, double b)
        {
            // get the squared value of each num.
            double aSq = a * a; 
            double bSq = b * b;
            double cSq = aSq + bSq;
            double c = Math.Sqrt(cSq);

            // calculate the PT. C^2 to the square root = 
            return c;
        }


    }
}
