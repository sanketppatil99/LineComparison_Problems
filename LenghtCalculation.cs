using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    public class LenghtCalculation
    {
        public void lenghtCalculation()
        {
            int x1 = 300;
            int x2 = 250;
            int y1 = 345;
            int y2 = 220;
            double lenght = 0.0;


            Console.WriteLine("Value of x1 co-ordinate is = {0} ", x1);

            Console.WriteLine("Value of y1 co-ordinate is = {0} ", x2);

            Console.WriteLine("Value of x2 co-ordinate is = {0} ", y1);

            Console.WriteLine("Value of y2 co-ordinate is = {0} ", y2);




            lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("The lenght of the line is {0} ", lenght);



        }
    }
}
