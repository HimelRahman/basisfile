using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circlde
    {

        public double radius;

        public double Getdiameter()
        {
            return (2*radius);
        }

        public double Getperimeter()
        {
            return (2*Math.PI*radius);
        }

        public double Getarea()
        {
           return  (radius*radius*Math.PI);
        }
    }
}
