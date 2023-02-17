using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    public class CheckEquality
    {
        public void checkEquality()
        {

            int x1 = 0, x3 = 0;
            int x2 = 0, x4 = 0;
            int y1 = 0, y3 = 0;
            int y2 = 0, y4 = 0;
            double lenght = 0.0;
            double lenght2 = 0.0;


            Console.WriteLine("Value of x1 co-ordinate is =  ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of y1 co-ordinate is =  ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of x2 co-ordinate is =  ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of y2 co-ordinate is =  ");
            y2 = Convert.ToInt32(Console.ReadLine());



            lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("The lenght of the line is {0} ", lenght);

            Console.WriteLine(".........................................");


            Console.WriteLine("Value of x3 co-ordinate is =  ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of y3 co-ordinate is =  ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of x4 co-ordinate is =  ");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of y4 co-ordinate is =  ");
            y4 = Convert.ToInt32(Console.ReadLine());



            lenght2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            Console.WriteLine("The lenght of the line is {0} ", lenght2);

            if (lenght == lenght2)
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }



        }
    }
}
