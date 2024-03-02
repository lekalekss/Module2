using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IShape
    {
        public double CalculateArea();

    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public static double Pi = 3.14;
        public double CalculateArea()            
        {
        
            return Pi * Radius * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Hight { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            return Hight * Width;
        }
    }


}
