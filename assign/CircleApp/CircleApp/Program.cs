using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Circlde acircle = new Circlde();
            double store = Convert.ToDouble(Console.ReadLine());
            acircle.radius = store;
            Console.WriteLine("diameter of circle:" + acircle.Getdiameter());
            Console.WriteLine("perimeter of circle:" + acircle.Getperimeter());
            Console.WriteLine("Area of circle:" + acircle.Getarea());
            Console.ReadKey();
        }
    }
}
